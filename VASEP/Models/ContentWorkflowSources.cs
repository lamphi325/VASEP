using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class ContentWorkflowSources
    {
        public int SourceId { get; set; }
        public int WorkflowId { get; set; }
        public string SourceName { get; set; }
        public string SourceType { get; set; }

        public ContentWorkflows Workflow { get; set; }
    }
}
