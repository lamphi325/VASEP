using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VASEP.Interfaces.Models.Media;

namespace VASEP.Interfaces
{
    public interface IMediaBusinessLogic
    {
        Task<VideoShowResponse> VideoGetList(VideoShowRequest request);

        Task<VideoDetailResponse> VideoDetail(VideoDetailRequest request);
    }
}
