using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VASEP.Interfaces.Models.Home;

namespace VASEP.Interfaces
{
    public interface IHomeBusinessLogic
    {
        Task<BaiMoiNhatResponse> BaiMoiNhat(BaiMoiNhatRequest request);

        Task<NewDetailResponse> NewDetail(NewDetailRequest request);

        Task<BaiMoiDanhMucResponse> BaiMoiDanhMuc(BaiMoiDanhMucRequest request);
    }
}
