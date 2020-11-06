using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class TabUrls
    {
        public int TabId { get; set; }
        public int SeqNum { get; set; }
        public string Url { get; set; }
        public string QueryString { get; set; }
        public string HttpStatus { get; set; }
        public string CultureCode { get; set; }
        public bool IsSystem { get; set; }
        public int? PortalAliasId { get; set; }
        public int? PortalAliasUsage { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public Tabs Tab { get; set; }
    }
}
