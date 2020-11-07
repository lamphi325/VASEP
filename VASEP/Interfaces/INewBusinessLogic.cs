using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VASEP.Interfaces.Models.New;

namespace VASEP.Interfaces
{
    public interface INewBusinessLogic
    {
        Task<NewGetListByCategoryIdResponse> NewGetListByCategoryId(NewGetListByCategoryIdRequest request);
    }
}
