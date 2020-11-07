using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VASEP.Common.Base;

namespace VASEP.Interfaces.Models.User
{
    public class LoginResponse : BaseResponse<ResponseStatus>
    {
        public int Id { get; set; }
        public string Token { get; set; }
    }
}
