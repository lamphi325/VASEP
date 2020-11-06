using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class Permission
    {
        public Permission()
        {
            ContentWorkflowStatePermission = new HashSet<ContentWorkflowStatePermission>();
            DesktopModulePermission = new HashSet<DesktopModulePermission>();
            FolderPermission = new HashSet<FolderPermission>();
            ModulePermission = new HashSet<ModulePermission>();
            TabPermission = new HashSet<TabPermission>();
        }

        public int PermissionId { get; set; }
        public string PermissionCode { get; set; }
        public int ModuleDefId { get; set; }
        public string PermissionKey { get; set; }
        public string PermissionName { get; set; }
        public int ViewOrder { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public ICollection<ContentWorkflowStatePermission> ContentWorkflowStatePermission { get; set; }
        public ICollection<DesktopModulePermission> DesktopModulePermission { get; set; }
        public ICollection<FolderPermission> FolderPermission { get; set; }
        public ICollection<ModulePermission> ModulePermission { get; set; }
        public ICollection<TabPermission> TabPermission { get; set; }
    }
}
