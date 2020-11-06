using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class Roles
    {
        public Roles()
        {
            DesktopModulePermission = new HashSet<DesktopModulePermission>();
            FolderPermission = new HashSet<FolderPermission>();
            ModulePermission = new HashSet<ModulePermission>();
            PersonaBarMenuPermission = new HashSet<PersonaBarMenuPermission>();
            TabPermission = new HashSet<TabPermission>();
            UserRoles = new HashSet<UserRoles>();
        }

        public int RoleId { get; set; }
        public int? PortalId { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public decimal? ServiceFee { get; set; }
        public string BillingFrequency { get; set; }
        public int? TrialPeriod { get; set; }
        public string TrialFrequency { get; set; }
        public int? BillingPeriod { get; set; }
        public decimal? TrialFee { get; set; }
        public bool IsPublic { get; set; }
        public bool AutoAssignment { get; set; }
        public int? RoleGroupId { get; set; }
        public string Rsvpcode { get; set; }
        public string IconFile { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public int Status { get; set; }
        public int SecurityMode { get; set; }
        public bool IsSystemRole { get; set; }

        public Portals Portal { get; set; }
        public RoleGroups RoleGroup { get; set; }
        public ICollection<DesktopModulePermission> DesktopModulePermission { get; set; }
        public ICollection<FolderPermission> FolderPermission { get; set; }
        public ICollection<ModulePermission> ModulePermission { get; set; }
        public ICollection<PersonaBarMenuPermission> PersonaBarMenuPermission { get; set; }
        public ICollection<TabPermission> TabPermission { get; set; }
        public ICollection<UserRoles> UserRoles { get; set; }
    }
}
