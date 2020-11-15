using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VASEP.Interfaces.Models.Common;
using VASEP.Interfaces.Models.Member;

namespace VASEP.Interfaces
{
    public interface IMemberBusinessLogic
    {
        Task<MemberGetListResponse> GetList(MemberGetListRequest request);

        Task<MemberGetByIdResponse> GetById(GetByIdRequest request);
    }
}
