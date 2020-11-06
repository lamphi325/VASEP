using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class Urls
    {
        public int UrlId { get; set; }
        public int? PortalId { get; set; }
        public string Url { get; set; }

        public Portals Portal { get; set; }
    }
}
