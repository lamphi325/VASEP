using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using VASEP.Common.Base;
using VASEP.Interfaces;
using VASEP.Interfaces.Models.User;
using VASEP.Models;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace VASEP.Implement
{
    public class UserBusinessLogic : IUserBusinessLogic
    {
        private readonly IConfiguration _configuration;

        public UserBusinessLogic(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<LoginResponse> Login(LoginRequest request)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(_configuration.GetValue<string>("ConnectionStrings:DefaultConnection")))
                {
                    AspnetMembership aspnetMembership = new AspnetMembership();
                    Mi user = new Mi();
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@UserName", request.UserName);
                    await Task.Run(() =>
                        aspnetMembership = connection.Query<AspnetMembership>("aspnet_Membership_GetByUserName", parameters, null, true, null, CommandType.StoredProcedure).FirstOrDefault()
                    );
                    if (aspnetMembership != null)
                    {
                        var passwordHashdle = Convert.ToBase64String((new Rfc2898DeriveBytes(request.Password, System.Convert.FromBase64String(aspnetMembership.PasswordSalt))).GetBytes(20));
                        if (passwordHashdle == aspnetMembership.Password)
                        {
                            await Task.Run(() =>
                                user = connection.Query<Mi>("MI_GetBy_UserName", parameters, null, true, null, CommandType.StoredProcedure).FirstOrDefault()
                            );
                            return new LoginResponse
                            {
                                Status = ResponseStatus.Success,
                                Message = ResponseStatus.Success.ToString(),
                                User = user,
                            };
                        }
                    }
                    return new LoginResponse
                    {
                        Status = ResponseStatus.Faile,
                        Message = "Tài khoản hoặc mật khẩu không đúng",
                        User = user,
                    };
                }
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

        public async Task<RegisterResponse> Register(RegisterRequest request)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(_configuration.GetValue<string>("ConnectionStrings:DefaultConnection")))
                {
                    DynamicParameters parameters = new DynamicParameters();
                    //parameters = new DynamicParameters();
                    //parameters.Add("@Id", null);
                    //parameters.Add("@UserId", null);
                    //parameters.Add("@Username", request.UserName.Trim());
                    //parameters.Add("@FirstName", request.FirstName.Trim());
                    //parameters.Add("@LastName", request.LastName.Trim());
                    //parameters.Add("@DisplayName", request.FirstName.Trim() + " " + request.LastName.Trim());
                    //parameters.Add("@ShortName", null);
                    //parameters.Add("@CompanyName", null);
                    //parameters.Add("@TradeNames", null);
                    //parameters.Add("@Field", null);
                    //parameters.Add("@TypeOfBusiness", null);
                    //parameters.Add("@MemberType", 0);
                    //parameters.Add("@Gender", null);
                    //parameters.Add("@DateOfBirth", null);
                    //parameters.Add("@Nationnality", 0);
                    //parameters.Add("@Email", request.Email ?? request.Email.Trim());
                    //parameters.Add("@Tel", request.PhoneNumber ?? request.PhoneNumber.Trim());
                    //parameters.Add("@Mobile", null);
                    //parameters.Add("@Fax", null);
                    //parameters.Add("@Website", null);
                    //parameters.Add("@City", null);
                    //parameters.Add("@Address", request.Address ?? request.Address.Trim());
                    //parameters.Add("@LanguageId", null);
                    //parameters.Add("@TypeId", null);
                    //parameters.Add("@Recommender", null);
                    //parameters.Add("@ProfileUrl", null);
                    //parameters.Add("@AvatarUrl", null);
                    //parameters.Add("@VerifyCode", null);
                    //parameters.Add("@IsVerified", null);
                    //parameters.Add("@IdCareers", 0);
                    //parameters.Add("@Products", null);
                    //parameters.Add("@Description", null);
                    //parameters.Add("@Quality", null);
                    //parameters.Add("@EUCode", null);
                    //parameters.Add("@ScopeOfWork", null);
                    //parameters.Add("@ExportMarket", null);
                    //parameters.Add("@EffectiveDate", null);
                    //parameters.Add("@ExpirationDate", null);
                    //parameters.Add("@CreateUserId", null);
                    //parameters.Add("@CreatedDate", DateTime.Now);
                    //parameters.Add("@UpdatedUserId", null);
                    //parameters.Add("@UpdatedDate", null);
                    //parameters.Add("@IsActive", true);
                    await Task.Run(() =>
                        connection.Query("MI_Insert", parameters, null, true, null, CommandType.StoredProcedure)
                    );
                    return new RegisterResponse
                    {
                        Status = ResponseStatus.Success,
                        Message = ResponseStatus.Success.ToString(),
                    };
                }
            }
            catch (Exception ex)
            {
                return new RegisterResponse
                {
                    Status = ResponseStatus.Faile,
                    Message = ex.Message,
                };
            }
        }
    }
}
