using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class JournalSecurity
    {
        public int JournalSecurityId { get; set; }
        public int JournalId { get; set; }
        public string SecurityKey { get; set; }
    }
}
