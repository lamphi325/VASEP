using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class ContentWorkflowLogs
    {
        public int WorkflowLogId { get; set; }
        public string Action { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
        public int User { get; set; }
        public int WorkflowId { get; set; }
        public int ContentItemId { get; set; }
        public int Type { get; set; }

        public ContentItems ContentItem { get; set; }
        public ContentWorkflows Workflow { get; set; }
    }
}
