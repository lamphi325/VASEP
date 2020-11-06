using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class Users
    {
        public Users()
        {
            ContentWorkflowStatePermission = new HashSet<ContentWorkflowStatePermission>();
            CoreMessagingSubscriptions = new HashSet<CoreMessagingSubscriptions>();
            DesktopModulePermission = new HashSet<DesktopModulePermission>();
            FolderPermission = new HashSet<FolderPermission>();
            ModulePermission = new HashSet<ModulePermission>();
            PasswordHistory = new HashSet<PasswordHistory>();
            PersonaBarMenuPermission = new HashSet<PersonaBarMenuPermission>();
            Profile = new HashSet<Profile>();
            Relationships = new HashSet<Relationships>();
            TabPermission = new HashSet<TabPermission>();
            UserAuthentication = new HashSet<UserAuthentication>();
            UserPortals = new HashSet<UserPortals>();
            UserProfile = new HashSet<UserProfile>();
            UserRelationshipPreferences = new HashSet<UserRelationshipPreferences>();
            UserRelationshipsRelatedUser = new HashSet<UserRelationships>();
            UserRelationshipsUser = new HashSet<UserRelationships>();
            UserRoles = new HashSet<UserRoles>();
            UsersOnline = new HashSet<UsersOnline>();
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsSuperUser { get; set; }
        public int? AffiliateId { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public bool UpdatePassword { get; set; }
        public string LastIpaddress { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public Guid? PasswordResetToken { get; set; }
        public DateTime? PasswordResetExpiration { get; set; }

        public ICollection<ContentWorkflowStatePermission> ContentWorkflowStatePermission { get; set; }
        public ICollection<CoreMessagingSubscriptions> CoreMessagingSubscriptions { get; set; }
        public ICollection<DesktopModulePermission> DesktopModulePermission { get; set; }
        public ICollection<FolderPermission> FolderPermission { get; set; }
        public ICollection<ModulePermission> ModulePermission { get; set; }
        public ICollection<PasswordHistory> PasswordHistory { get; set; }
        public ICollection<PersonaBarMenuPermission> PersonaBarMenuPermission { get; set; }
        public ICollection<Profile> Profile { get; set; }
        public ICollection<Relationships> Relationships { get; set; }
        public ICollection<TabPermission> TabPermission { get; set; }
        public ICollection<UserAuthentication> UserAuthentication { get; set; }
        public ICollection<UserPortals> UserPortals { get; set; }
        public ICollection<UserProfile> UserProfile { get; set; }
        public ICollection<UserRelationshipPreferences> UserRelationshipPreferences { get; set; }
        public ICollection<UserRelationships> UserRelationshipsRelatedUser { get; set; }
        public ICollection<UserRelationships> UserRelationshipsUser { get; set; }
        public ICollection<UserRoles> UserRoles { get; set; }
        public ICollection<UsersOnline> UsersOnline { get; set; }
    }
}
