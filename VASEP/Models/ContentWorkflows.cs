using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class ContentWorkflows
    {
        public ContentWorkflows()
        {
            ContentWorkflowLogs = new HashSet<ContentWorkflowLogs>();
            ContentWorkflowSources = new HashSet<ContentWorkflowSources>();
            ContentWorkflowStates = new HashSet<ContentWorkflowStates>();
            Folders = new HashSet<Folders>();
        }

        public int WorkflowId { get; set; }
        public int? PortalId { get; set; }
        public string WorkflowName { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public bool? StartAfterCreating { get; set; }
        public bool? StartAfterEditing { get; set; }
        public bool DispositionEnabled { get; set; }
        public bool IsSystem { get; set; }
        public string WorkflowKey { get; set; }

        public ICollection<ContentWorkflowLogs> ContentWorkflowLogs { get; set; }
        public ICollection<ContentWorkflowSources> ContentWorkflowSources { get; set; }
        public ICollection<ContentWorkflowStates> ContentWorkflowStates { get; set; }
        public ICollection<Folders> Folders { get; set; }
    }
}
