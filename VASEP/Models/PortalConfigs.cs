using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class PortalConfigs
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }
        public string BannerLeft { get; set; }
        public string BannerRight { get; set; }
        public string BannerFooter { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? PortalId { get; set; }
        public string LanguageId { get; set; }
    }
}
