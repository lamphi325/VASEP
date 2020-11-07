using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VASEP.Common.Base;

namespace VASEP.Interfaces.Models.Home
{
    public class BaiMoiDanhMucResponse : BaseResponse<ResponseStatus>
    {
        public List<NewDetail> LstData { get; set; }
    }
}
