using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class BannerStatic
    {
        public int Id { get; set; }
        public int? BannerId { get; set; }
        public string Ip { get; set; }
        public DateTime? Createdate { get; set; }
        public long? Isclick { get; set; }
    }
}
