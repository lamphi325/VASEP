using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class Workflow
    {
        public Workflow()
        {
            WorkflowStates = new HashSet<WorkflowStates>();
        }

        public int WorkflowId { get; set; }
        public int? PortalId { get; set; }
        public string WorkflowName { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<WorkflowStates> WorkflowStates { get; set; }
    }
}
