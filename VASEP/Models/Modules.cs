using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class Modules
    {
        public Modules()
        {
            CoreMessagingSubscriptions = new HashSet<CoreMessagingSubscriptions>();
            HtmlText = new HashSet<HtmlText>();
            ModulePermission = new HashSet<ModulePermission>();
            ModuleSettings = new HashSet<ModuleSettings>();
            TabModules = new HashSet<TabModules>();
        }

        public int ModuleId { get; set; }
        public int ModuleDefId { get; set; }
        public bool AllTabs { get; set; }
        public bool IsDeleted { get; set; }
        public bool? InheritViewPermissions { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? PortalId { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public DateTime? LastContentModifiedOnDate { get; set; }
        public int? ContentItemId { get; set; }
        public bool? IsShareable { get; set; }
        public bool? IsShareableViewOnly { get; set; }

        public ContentItems ContentItem { get; set; }
        public ModuleDefinitions ModuleDef { get; set; }
        public ICollection<CoreMessagingSubscriptions> CoreMessagingSubscriptions { get; set; }
        public ICollection<HtmlText> HtmlText { get; set; }
        public ICollection<ModulePermission> ModulePermission { get; set; }
        public ICollection<ModuleSettings> ModuleSettings { get; set; }
        public ICollection<TabModules> TabModules { get; set; }
    }
}
