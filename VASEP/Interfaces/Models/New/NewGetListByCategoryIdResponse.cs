using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VASEP.Common.Base;

namespace VASEP.Interfaces.Models.New
{
    public class NewGetListByCategoryIdResponse : BaseResponse<ResponseStatus>
    {
        public List<NewObject> LstData { get; set; }
        public int TotalRecords { get; set; }
    }
}
