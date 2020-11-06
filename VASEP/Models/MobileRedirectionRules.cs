using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class MobileRedirectionRules
    {
        public int Id { get; set; }
        public int RedirectionId { get; set; }
        public string Capability { get; set; }
        public string Expression { get; set; }

        public MobileRedirections Redirection { get; set; }
    }
}
