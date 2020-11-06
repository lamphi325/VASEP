using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VASEP.Common.Base;

namespace VASEP.Interfaces.Models.Home
{
    public class BaiMoiNhatResponse : BaseResponse<ResponseStatus>
    {
        public List<NewBaiMoiNhat> LstBaiMoiNhat { get; set; }
    }

    public class NewBaiMoiNhat
    {
        public string Type { get; set; }
        public List<NewBaiMoiNhatData> Data { get; set; }
    }

    public class NewBaiMoiNhatData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string UrlToImage { get; set; }
        public DateTime? PublishedAt { get; set; }
        public string Content { get; set; }
    }
}
