using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class UserPortals
    {
        public int UserId { get; set; }
        public int PortalId { get; set; }
        public int UserPortalId { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool? Authorised { get; set; }
        public bool IsDeleted { get; set; }
        public bool RefreshRoles { get; set; }
        public string VanityUrl { get; set; }

        public Portals Portal { get; set; }
        public Users User { get; set; }
    }
}
