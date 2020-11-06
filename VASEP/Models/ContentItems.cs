using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class ContentItems
    {
        public ContentItems()
        {
            ContentItemsMetaData = new HashSet<ContentItemsMetaData>();
            ContentItemsTags = new HashSet<ContentItemsTags>();
            ContentWorkflowLogs = new HashSet<ContentWorkflowLogs>();
            Files = new HashSet<Files>();
            Modules = new HashSet<Modules>();
            Tabs = new HashSet<Tabs>();
        }

        public int ContentItemId { get; set; }
        public string Content { get; set; }
        public int ContentTypeId { get; set; }
        public int TabId { get; set; }
        public int ModuleId { get; set; }
        public string ContentKey { get; set; }
        public bool Indexed { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public int? StateId { get; set; }

        public ContentTypes ContentType { get; set; }
        public ContentWorkflowStates State { get; set; }
        public ICollection<ContentItemsMetaData> ContentItemsMetaData { get; set; }
        public ICollection<ContentItemsTags> ContentItemsTags { get; set; }
        public ICollection<ContentWorkflowLogs> ContentWorkflowLogs { get; set; }
        public ICollection<Files> Files { get; set; }
        public ICollection<Modules> Modules { get; set; }
        public ICollection<Tabs> Tabs { get; set; }
    }
}
