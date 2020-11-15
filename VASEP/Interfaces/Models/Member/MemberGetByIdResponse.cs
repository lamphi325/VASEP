using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VASEP.Common.Base;

namespace VASEP.Interfaces.Models.Member
{
    public class MemberGetByIdResponse : BaseResponse<ResponseStatus>
    {
        public MemberGetById Member { get; set; }
    }

    public class MemberGetById
    {
        public int Id { get; set; }
        public string AvatarUrl { get; set; }
        public string CompanyName { get; set; }
        public string TradeNames { get; set; }
        public string Field { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string EUCode { get; set; }
        public string Quality { get; set; }
        public string Products { get; set; }
    }
}
