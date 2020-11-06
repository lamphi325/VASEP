using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class PersonaBarMenuPermission
    {
        public int MenuPermissionId { get; set; }
        public int? PortalId { get; set; }
        public int MenuId { get; set; }
        public int PermissionId { get; set; }
        public bool AllowAccess { get; set; }
        public int? RoleId { get; set; }
        public int? UserId { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public PersonaBarMenu Menu { get; set; }
        public PersonaBarPermission Permission { get; set; }
        public Portals Portal { get; set; }
        public Roles Role { get; set; }
        public Users User { get; set; }
    }
}
