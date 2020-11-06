using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class AnonymousUsers
    {
        public string UserId { get; set; }
        public int PortalId { get; set; }
        public int TabId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastActiveDate { get; set; }

        public Portals Portal { get; set; }
    }
}
