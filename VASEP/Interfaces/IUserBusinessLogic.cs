using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VASEP.Interfaces.Models.User;

namespace VASEP.Interfaces
{
    public interface IUserBusinessLogic
    {
        Task<LoginResponse> Login(LoginRequest request);
        Task<RegisterResponse> Register(RegisterRequest request);
    }
}
