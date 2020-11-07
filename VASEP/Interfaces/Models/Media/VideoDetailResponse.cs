using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VASEP.Common.Base;

namespace VASEP.Interfaces.Models.Media
{
    public class VideoDetailResponse : BaseResponse<ResponseStatus>
    {
        public VideoObject Video { get; set; }
    }

    public class VideoObject
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string LinkVideos { get; set; }
        public string Tomtat { get; set; }
        public DateTime? PublicDate { get; set; }
        public int Luotxem { get; set; }
        public string Avatar { get; set; }
    }
}
