using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VASEP.Interfaces;
using VASEP.Interfaces.Models.User;

namespace VASEP.Implement
{
    public class UserBusinessLogic : IUserBusinessLogic
    {
        public Task<LoginResponse> Login(LoginRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<RegisterResponse> Register(RegisterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
