﻿using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class Tabs
    {
        public Tabs()
        {
            InverseParent = new HashSet<Tabs>();
            TabModules = new HashSet<TabModules>();
            TabPermission = new HashSet<TabPermission>();
            TabSettings = new HashSet<TabSettings>();
            TabUrls = new HashSet<TabUrls>();
            TabVersions = new HashSet<TabVersions>();
        }

        public int TabId { get; set; }
        public int TabOrder { get; set; }
        public int? PortalId { get; set; }
        public string TabName { get; set; }
        public bool? IsVisible { get; set; }
        public int? ParentId { get; set; }
        public string IconFile { get; set; }
        public bool DisableLink { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string KeyWords { get; set; }
        public bool IsDeleted { get; set; }
        public string Url { get; set; }
        public string SkinSrc { get; set; }
        public string ContainerSrc { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? RefreshInterval { get; set; }
        public string PageHeadText { get; set; }
        public bool IsSecure { get; set; }
        public bool PermanentRedirect { get; set; }
        public double SiteMapPriority { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public string IconFileLarge { get; set; }
        public string CultureCode { get; set; }
        public int? ContentItemId { get; set; }
        public Guid UniqueId { get; set; }
        public Guid VersionGuid { get; set; }
        public Guid? DefaultLanguageGuid { get; set; }
        public Guid LocalizedVersionGuid { get; set; }
        public int Level { get; set; }
        public string TabPath { get; set; }
        public bool HasBeenPublished { get; set; }
        public bool IsSystem { get; set; }

        public ContentItems ContentItem { get; set; }
        public Tabs Parent { get; set; }
        public Portals Portal { get; set; }
        public ICollection<Tabs> InverseParent { get; set; }
        public ICollection<TabModules> TabModules { get; set; }
        public ICollection<TabPermission> TabPermission { get; set; }
        public ICollection<TabSettings> TabSettings { get; set; }
        public ICollection<TabUrls> TabUrls { get; set; }
        public ICollection<TabVersions> TabVersions { get; set; }
    }
}
