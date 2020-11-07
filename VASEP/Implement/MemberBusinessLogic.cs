using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VASEP.Interfaces;
using VASEP.Interfaces.Models.Member;

namespace VASEP.Implement
{
    public class MemberBusinessLogic : IMemberBusinessLogic
    {
        public Task<MemberGetListResponse> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
