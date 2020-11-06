using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class FolderPermission
    {
        public int FolderPermissionId { get; set; }
        public int FolderId { get; set; }
        public int PermissionId { get; set; }
        public bool AllowAccess { get; set; }
        public int? RoleId { get; set; }
        public int? UserId { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public Folders Folder { get; set; }
        public Permission Permission { get; set; }
        public Roles Role { get; set; }
        public Users User { get; set; }
    }
}
