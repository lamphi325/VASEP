using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VASEP.Common.Base
{
    public class BaseResponse<T>
    {
        public T Status { get; set; }
        public string Message { get; set; }
    }
}
