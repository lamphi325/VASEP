using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VASEP.Common.Base;

namespace VASEP.Interfaces.Models.Member
{
    public class MemberGetListResponse : BaseResponse<ResponseStatus>
    {
        public List<MemberGetList> LstData { get; set; }
        public int TotalRecords { get; set; }
    }

    public class MemberGetList
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string AvatarUrl { get; set; }
    }
}
