using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VASEP.Common.Base;

namespace VASEP.Interfaces.Models.User
{
    public class RegisterResponse : BaseResponse<ResponseStatus>
    {
        public object Errors { get; set; }
    }
}
