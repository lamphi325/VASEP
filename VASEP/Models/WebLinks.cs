using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class WebLinks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? OrderNo { get; set; }
        public string Url { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int? PortalId { get; set; }
        public int? ModuleId { get; set; }
        public string LanguageId { get; set; }
        public int? ViewCount { get; set; }
        public string ViewType { get; set; }
        public string Accounts { get; set; }
    }
}
