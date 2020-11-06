using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class Profile
    {
        public int ProfileId { get; set; }
        public int UserId { get; set; }
        public int PortalId { get; set; }
        public string ProfileData { get; set; }
        public DateTime CreatedDate { get; set; }

        public Portals Portal { get; set; }
        public Users User { get; set; }
    }
}
