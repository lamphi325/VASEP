using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class SystemMessages
    {
        public int MessageId { get; set; }
        public int? PortalId { get; set; }
        public string MessageName { get; set; }
        public string MessageValue { get; set; }

        public Portals Portal { get; set; }
    }
}
