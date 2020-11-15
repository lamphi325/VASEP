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
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using VASEP.Common;
using VASEP.Common.Base;
using VASEP.Common.Encrypt;
using VASEP.Interfaces;
using VASEP.Interfaces.Models.User;
using VASEP.Models;

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
                        User = user.User,
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

        [HttpPost("DecryPassword")]
        public string DecryPassword([FromBody] string password)
        {
            using (IDbConnection connection = new SqlConnection(_configuration.GetValue<string>("ConnectionStrings:DefaultConnection")))
            {
                AspnetMembership aspnetMembership = new AspnetMembership();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@UserName", "admin");

                aspnetMembership = connection.Query<AspnetMembership>("aspnet_Membership_GetByUserName", parameters, null, true, null, CommandType.StoredProcedure).FirstOrDefault();
                var bytes = Encoding.UTF8.GetBytes(aspnetMembership.PasswordSalt);
                var decry = AES.Encrypt(password, bytes);
                return decry;
            }
        }
    }
}