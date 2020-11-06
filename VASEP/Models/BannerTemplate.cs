using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class BannerTemplate
    {
        public int Id { get; set; }
        public string TemplateName { get; set; }
        public string FilePath { get; set; }
        public int? PortalId { get; set; }
    }
}
