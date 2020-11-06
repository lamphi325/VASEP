using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class Portals
    {
        public Portals()
        {
            AnonymousUsers = new HashSet<AnonymousUsers>();
            CoreMessagingSubscriptions = new HashSet<CoreMessagingSubscriptions>();
            Files = new HashSet<Files>();
            FolderMappings = new HashSet<FolderMappings>();
            Folders = new HashSet<Folders>();
            MobilePreviewProfiles = new HashSet<MobilePreviewProfiles>();
            MobileRedirections = new HashSet<MobileRedirections>();
            PersonaBarMenuPermission = new HashSet<PersonaBarMenuPermission>();
            PortalAlias = new HashSet<PortalAlias>();
            PortalDesktopModules = new HashSet<PortalDesktopModules>();
            PortalLanguages = new HashSet<PortalLanguages>();
            PortalLocalization = new HashSet<PortalLocalization>();
            PortalSettings = new HashSet<PortalSettings>();
            Profile = new HashSet<Profile>();
            ProfilePropertyDefinition = new HashSet<ProfilePropertyDefinition>();
            Relationships = new HashSet<Relationships>();
            RoleGroups = new HashSet<RoleGroups>();
            Roles = new HashSet<Roles>();
            SiteLog = new HashSet<SiteLog>();
            SystemMessages = new HashSet<SystemMessages>();
            Tabs = new HashSet<Tabs>();
            UrlTracking = new HashSet<UrlTracking>();
            Urls = new HashSet<Urls>();
            UserPortals = new HashSet<UserPortals>();
            UsersOnline = new HashSet<UsersOnline>();
        }

        public int PortalId { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int UserRegistration { get; set; }
        public int BannerAdvertising { get; set; }
        public int? AdministratorId { get; set; }
        public string Currency { get; set; }
        public decimal HostFee { get; set; }
        public int HostSpace { get; set; }
        public int? AdministratorRoleId { get; set; }
        public int? RegisteredRoleId { get; set; }
        public Guid Guid { get; set; }
        public string PaymentProcessor { get; set; }
        public string ProcessorUserId { get; set; }
        public string ProcessorPassword { get; set; }
        public int? SiteLogHistory { get; set; }
        public string DefaultLanguage { get; set; }
        public int TimezoneOffset { get; set; }
        public string HomeDirectory { get; set; }
        public int PageQuota { get; set; }
        public int UserQuota { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public int? PortalGroupId { get; set; }

        public ICollection<AnonymousUsers> AnonymousUsers { get; set; }
        public ICollection<CoreMessagingSubscriptions> CoreMessagingSubscriptions { get; set; }
        public ICollection<Files> Files { get; set; }
        public ICollection<FolderMappings> FolderMappings { get; set; }
        public ICollection<Folders> Folders { get; set; }
        public ICollection<MobilePreviewProfiles> MobilePreviewProfiles { get; set; }
        public ICollection<MobileRedirections> MobileRedirections { get; set; }
        public ICollection<PersonaBarMenuPermission> PersonaBarMenuPermission { get; set; }
        public ICollection<PortalAlias> PortalAlias { get; set; }
        public ICollection<PortalDesktopModules> PortalDesktopModules { get; set; }
        public ICollection<PortalLanguages> PortalLanguages { get; set; }
        public ICollection<PortalLocalization> PortalLocalization { get; set; }
        public ICollection<PortalSettings> PortalSettings { get; set; }
        public ICollection<Profile> Profile { get; set; }
        public ICollection<ProfilePropertyDefinition> ProfilePropertyDefinition { get; set; }
        public ICollection<Relationships> Relationships { get; set; }
        public ICollection<RoleGroups> RoleGroups { get; set; }
        public ICollection<Roles> Roles { get; set; }
        public ICollection<SiteLog> SiteLog { get; set; }
        public ICollection<SystemMessages> SystemMessages { get; set; }
        public ICollection<Tabs> Tabs { get; set; }
        public ICollection<UrlTracking> UrlTracking { get; set; }
        public ICollection<Urls> Urls { get; set; }
        public ICollection<UserPortals> UserPortals { get; set; }
        public ICollection<UsersOnline> UsersOnline { get; set; }
    }
}
