using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VASEP.Common.Base;
using VASEP.Models;

namespace VASEP.Interfaces.Models.User
{
    public class LoginResponse : BaseResponse<ResponseStatus>
    {
        public string Token { get; set; }
        public Mi User { get; set; }
    }
}
