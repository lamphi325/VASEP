using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using VASEP.Common.Base;
using VASEP.Interfaces;
using VASEP.Interfaces.Models.User;

namespace VASEP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        private readonly IUserBusinessLogic _businessLogic;

        public AccountController(IConfiguration configuration,
            IUserBusinessLogic businessLogic)
        {
            _configuration = configuration;
            _businessLogic = businessLogic;
        }

        [HttpPost("Login")]
        [AllowAnonymous]
        public async Task<LoginResponse> Login([FromBody] LoginRequest request)
        {
            try
            {
                var user = await _businessLogic.Login(request);

                //replace below with your key found in web.config file of DNN installation
                var keyString = "7720BDAF296F5840DBD6189F3A1FA5BFEC1430D8085B1ECC";
                int discarded = 0;
                var key = HexEncoding.GetBytes(keyString, out discarded);
                var iv = new byte[8];
                //replace below with salt found in [aspnet_Membership] table [PasswordSalt] of user whose password you need to decrypt
                var saltString = "7JhHSow7bPPYY65oIpCUVw==";
                var salt = Convert.FromBase64String(saltString);
                string saltHex = HexEncoding.ToString(salt);
                //replace below with password found in [aspnet_Membership] table [Password] of user whose password you need to decrypt
                var valueString = "4gVdMifvbg7Fb3jZfzfy5qmesl73f14bZq/lJyp82fg=";
                var value = Convert.FromBase64String(valueString);

                Utilities.Crypto.SymmetricCryptography<TripleDESCryptoServiceProvider> sec =
                  new Utilities.Crypto.SymmetricCryptography<TripleDESCryptoServiceProvider>(key, iv);

                //remove salt from result
                byte[] dec2 = sec.Decrypt(value);
                byte[] dec3 = new byte[dec2.Length - salt.Length];
                int j = 0;
                for (int i = 0; i < dec2.Length; i++)
                {
                    if (i > salt.Length - 1)
                    {
                        dec3[j] = dec2[i];
                        j++;
                    }
                }

                //count null chars
                j = 0;
                for (int i = 0; i < dec3.Length; i++)
                {
                    if (dec3[i] == 0)
                    {
                        j++;
                    }
                }
                //remove null chars
                byte[] dec4 = new byte[dec3.Length - j];
                j = 0;
                for (int i = 0; i < dec3.Length; i++)
                {
                    if (dec3[i] != 0)
                    {
                        dec4[j] = dec3[i];
                        j++;
                    }
                }

                string password1 = Encoding.UTF8.GetString(dec4);

                if (user.Status == ResponseStatus.Success)
                {
                    IdentityUser identityUser = new IdentityUser
                    {
                        UserName = request.UserName.Trim(),
                        Id = user.User.UserId.ToString(),
                    };
                    var token = await GenerateJwtToken(request.UserName, identityUser, new List<string>());
                    return new LoginResponse
                    {
                        Status = ResponseStatus.Success,
                        Message = ResponseStatus.Success.ToString(),
                        Token = token,
                    };
                }
                return user;
            }
            catch (Exception ex)
            {
                return new LoginResponse
                {
                    Status = ResponseStatus.Faile,
                    Message = ex.Message,
                };
            }
        }

        [HttpPost("Register")]
        public RegisterResponse Register([FromBody] RegisterRequest request)
        {
            return new RegisterResponse
            {
                Status = ResponseStatus.Success,
                Message = ResponseStatus.Success.ToString(),
            };
        }

        private async Task<string> GenerateJwtToken(string userName, IdentityUser user, List<string> permissions)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, userName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.Id)
            };

            foreach (var permission in permissions)
            {
                claims.Add(new Claim(ClaimTypes.Role, permission));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:JwtKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddHours(Convert.ToDouble(_configuration["Jwt:JwtExpireHours"]));

            var token = new JwtSecurityToken(
                _configuration["Jwt:JwtIssuer"],
                _configuration["Jwt:JwtIssuer"],
                claims,
                expires: expires,
                signingCredentials: creds
            );

            return await Task.FromResult(new JwtSecurityTokenHandler().WriteToken(token));
        }
    }

    public class SymmetricCryptography<T> where T : SymmetricAlgorithm, new()
    {
        #region Fields

        private T _provider = new T();
        private UTF8Encoding _utf8 = new UTF8Encoding();

        #endregion Fields

        #region Properties

        private byte[] _key;
        public byte[] Key
        {
            get { return _key; }
            set { _key = value; }
        }

        private byte[] _iv;
        public byte[] IV
        {
            get { return _iv; }
            set { _iv = value; }
        }

        #endregion Properties

        #region Constructors

        public SymmetricCryptography()
        {
            _provider.GenerateKey();
            _key = _provider.Key;
            _provider.GenerateIV();
            _iv = _provider.IV;
        }

        public SymmetricCryptography(byte[] key, byte[] iv)
        {
            _key = key;
            if (iv == null)
            {
                _provider.Key = key;
                _provider.GenerateIV();
                iv = _provider.IV;
            }
            _iv = iv;
        }

        #endregion Constructors

        #region Byte Array Methods

        public byte[] Encrypt(byte[] input)
        {
            return Encrypt(input, _key, _iv);
        }

        public byte[] Decrypt(byte[] input)
        {
            return Decrypt(input, _key, _iv);
        }

        public byte[] Encrypt(byte[] input, byte[] key, byte[] iv)
        {
            return Transform(input,
                   _provider.CreateEncryptor(key, iv));
        }

        public byte[] Decrypt(byte[] input, byte[] key, byte[] iv)
        {
            return Transform(input,
                   _provider.CreateDecryptor(key, iv));
        }

        #endregion Byte Array Methods

        #region String Methods

        public string Encrypt(string text)
        {
            return Encrypt(text, _key, _iv);
        }

        public string Decrypt(string text)
        {
            return Decrypt(text, _key, _iv);
        }

        public string Encrypt(string text, byte[] key, byte[] iv)
        {
            byte[] output = Transform(_utf8.GetBytes(text),
                            _provider.CreateEncryptor(key, iv));
            return Convert.ToBase64String(output);
        }

        public string Decrypt(string text, byte[] key, byte[] iv)
        {
            byte[] output = Transform(Convert.FromBase64String(text),
                            _provider.CreateDecryptor(key, iv));
            return _utf8.GetString(output);
        }

        #endregion String Methods

        #region SecureString Methods

        public byte[] Encrypt(SecureString input)
        {
            return Encrypt(input, _key, _iv);
        }

        public void Decrypt(byte[] input, out SecureString output)
        {
            Decrypt(input, out output, _key, _iv);
        }

        public byte[] Encrypt(SecureString input, byte[] key, byte[] iv)
        {
            // defensive argument checking
            if (input == null)
                throw new ArgumentNullException("input");

            IntPtr inputPtr = IntPtr.Zero;

            try
            {
                // copy the SecureString to an unmanaged BSTR
                // and get back the pointer to the memory location
                inputPtr = Marshal.SecureStringToBSTR(input);
                if (inputPtr == IntPtr.Zero)
                    throw new InvalidOperationException("Unable to allocate" +
                        "necessary unmanaged resources.");

                char[] inputBuffer = new char[input.Length];

                try
                {
                    // pin the buffer array so the GC doesn't move it while we
                    // are doing an unmanaged memory copy, but make sure we 
                    // release the pin when we are done so that the CLR can do
                    // its thing later
                    GCHandle handle = GCHandle.Alloc(inputBuffer,
                        GCHandleType.Pinned);
                    try
                    {
                        Marshal.Copy(inputPtr, inputBuffer, 0, input.Length);
                    }
                    finally
                    {
                        handle.Free();
                    }

                    // encode the input as UTF8 first so that we have a
                    // way to explicitly "flush" the byte array afterwards
                    byte[] utf8Buffer = _utf8.GetBytes(inputBuffer);
                    try
                    {
                        return Encrypt(utf8Buffer, key, iv);
                    }
                    finally
                    {
                        Array.Clear(utf8Buffer, 0, utf8Buffer.Length);
                    }
                }
                finally
                {
                    Array.Clear(inputBuffer, 0, inputBuffer.Length);
                }
            }
            finally
            {
                // because we are using unmanaged resources, we *must*
                // explicitly deallocate those resources ourselves
                if (inputPtr != IntPtr.Zero)
                    Marshal.ZeroFreeBSTR(inputPtr);
            }
        }

        public void Decrypt(byte[] input, out SecureString output, byte[] key,
            byte[] iv)
        {
            byte[] decryptedBuffer = null;

            try
            {
                // do our normal decryption of a byte array
                decryptedBuffer = Decrypt(input, key, iv);

                char[] outputBuffer = null;

                try
                {
                    // convert the decrypted array to an explicit
                    // character array that we can "flush" later
                    outputBuffer = _utf8.GetChars(decryptedBuffer);

                    // Create the result and copy the characters
                    output = new SecureString();
                    try
                    {
                        for (int i = 0; i < outputBuffer.Length; i++)
                            output.AppendChar(outputBuffer[i]);
                        return;
                    }
                    finally
                    {
                        output.MakeReadOnly();
                    }
                }
                finally
                {
                    if (outputBuffer != null)
                        Array.Clear(outputBuffer, 0, outputBuffer.Length);
                }
            }
            finally
            {
                if (decryptedBuffer != null)
                    Array.Clear(decryptedBuffer, 0, decryptedBuffer.Length);
            }
        }

        #endregion SecureString Methods

        #region Stream Methods

        public void Encrypt(Stream input, Stream output)
        {
            Encrypt(input, output, _key, _iv);
        }

        public void Decrypt(Stream input, Stream output)
        {
            Decrypt(input, output, _key, _iv);
        }

        public void Encrypt(Stream input, Stream output, byte[] key,
            byte[] iv)
        {
            TransformStream(true, ref input, ref output, key, iv);
        }

        public void Decrypt(Stream input, Stream output, byte[] key,
            byte[] iv)
        {
            TransformStream(false, ref input, ref output, key, iv);
        }

        #endregion Stream Methods

        #region Private Methods

        private byte[] Transform(byte[] input,
                       ICryptoTransform CryptoTransform)
        {
            // create the necessary streams
            MemoryStream memStream = new MemoryStream();
            CryptoStream cryptStream = new CryptoStream(memStream,
                         CryptoTransform, CryptoStreamMode.Write);
            // transform the bytes as requested
            cryptStream.Write(input, 0, input.Length);
            cryptStream.FlushFinalBlock();
            // Read the memory stream and
            // convert it back into byte array
            memStream.Position = 0;
            byte[] result = memStream.ToArray();
            // close and release the streams
            memStream.Close();
            cryptStream.Close();
            // hand back the encrypted buffer
            return result;
        }

        private void TransformStream(bool encrypt, ref Stream input,
            ref Stream output, byte[] key, byte[] iv)
        {
            // defensive argument checking
            if (input == null)
                throw new ArgumentNullException("input");
            if (output == null)
                throw new ArgumentNullException("output");
            if (!input.CanRead)
                throw new ArgumentException("Unable to read from the input" +
                    "Stream.", "input");
            if (!output.CanWrite)
                throw new ArgumentException("Unable to write to the output" +
                    "Stream.", "output");
            // make the buffer just large enough for 
            // the portion of the stream to be processed
            byte[] inputBuffer = new byte[input.Length - input.Position];
            // read the stream into the buffer
            input.Read(inputBuffer, 0, inputBuffer.Length);
            // transform the buffer
            byte[] outputBuffer = encrypt ? Encrypt(inputBuffer, key, iv)
                                          : Decrypt(inputBuffer, key, iv);
            // write the transformed buffer to our output stream 
            output.Write(outputBuffer, 0, outputBuffer.Length);
        }
    }

    public class HexEncoding
    {
        public HexEncoding()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public static int GetByteCount(string hexString)
        {
            int numHexChars = 0;
            char c;
            // remove all none A-F, 0-9, characters
            for (int i = 0; i < hexString.Length; i++)
            {
                c = hexString[i];
                if (IsHexDigit(c))
                    numHexChars++;
            }
            // if odd number of characters, discard last character
            if (numHexChars % 2 != 0)
            {
                numHexChars--;
            }
            return numHexChars / 2; // 2 characters per byte
        }
        /// <summary>
        /// Creates a byte array from the hexadecimal string. Each two characters are combined
        /// to create one byte. First two hexadecimal characters become first byte in returned array.
        /// Non-hexadecimal characters are ignored. 
        /// </summary>
        /// <param name="hexString">string to convert to byte array</param>
        /// <param name="discarded">number of characters in string ignored</param>
        /// <returns>byte array, in the same left-to-right order as the hexString</returns>
        public static byte[] GetBytes(string hexString, out int discarded)
        {
            discarded = 0;
            string newString = "";
            char c;
            // remove all none A-F, 0-9, characters
            for (int i = 0; i < hexString.Length; i++)
            {
                c = hexString[i];
                if (IsHexDigit(c))
                    newString += c;
                else
                    discarded++;
            }
            // if odd number of characters, discard last character
            if (newString.Length % 2 != 0)
            {
                discarded++;
                newString = newString.Substring(0, newString.Length - 1);
            }

            int byteLength = newString.Length / 2;
            byte[] bytes = new byte[byteLength];
            string hex;
            int j = 0;
            for (int i = 0; i < bytes.Length; i++)
            {
                hex = new String(new Char[] { newString[j], newString[j + 1] });
                bytes[i] = HexToByte(hex);
                j = j + 2;
            }
            return bytes;
        }
        public static string ToString(byte[] bytes)
        {
            string hexString = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                hexString += bytes[i].ToString("X2");
            }
            return hexString;
        }
        /// <summary>
        /// Determines if given string is in proper hexadecimal string format
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        public static bool InHexFormat(string hexString)
        {
            bool hexFormat = true;

            foreach (char digit in hexString)
            {
                if (!IsHexDigit(digit))
                {
                    hexFormat = false;
                    break;
                }
            }
            return hexFormat;
        }

        /// <summary>
        /// Returns true is c is a hexadecimal digit (A-F, a-f, 0-9)
        /// </summary>
        /// <param name="c">Character to test</param>
        /// <returns>true if hex digit, false if not</returns>
        public static bool IsHexDigit(Char c)
        {
            int numChar;
            int numA = Convert.ToInt32('A');
            int num1 = Convert.ToInt32('0');
            c = Char.ToUpper(c);
            numChar = Convert.ToInt32(c);
            if (numChar >= numA && numChar < (numA + 6))
                return true;
            if (numChar >= num1 && numChar < (num1 + 10))
                return true;
            return false;
        }
        /// <summary>
        /// Converts 1 or 2 character string into equivalant byte value
        /// </summary>
        /// <param name="hex">1 or 2 character string</param>
        /// <returns>byte</returns>
        private static byte HexToByte(string hex)
        {
            if (hex.Length > 2 || hex.Length <= 0)
                throw new ArgumentException("hex must be 1 or 2 characters in length");
            byte newByte = byte.Parse(hex, System.Globalization.NumberStyles.HexNumber);
            return newByte;
        }
    }
}