using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class ModulePermission
    {
        public int ModulePermissionId { get; set; }
        public int ModuleId { get; set; }
        public int PermissionId { get; set; }
        public bool AllowAccess { get; set; }
        public int? RoleId { get; set; }
        public int? UserId { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public int PortalId { get; set; }

        public Modules Module { get; set; }
        public Permission Permission { get; set; }
        public Roles Role { get; set; }
        public Users User { get; set; }
    }
}
