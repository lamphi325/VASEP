using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VASEP.Interfaces.Models.Common;
using VASEP.Interfaces.Models.Document;

namespace VASEP.Interfaces
{
    public interface IDocumentBusinessLogic
    {
        Task<DocumentGetListResponse> GetList(DocumentGetListRequest request);

        Task<DocumentDetailResponse> DocumentDetail(DocumentDetailRequest request);

        Task<UpdateViewCountResponse> UpdateViewCount(GetByIdRequest request);
    }
}
