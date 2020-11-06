using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class WorkflowStates
    {
        public WorkflowStates()
        {
            HtmlText = new HashSet<HtmlText>();
            HtmlTextLog = new HashSet<HtmlTextLog>();
        }

        public int StateId { get; set; }
        public int WorkflowId { get; set; }
        public string StateName { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; }
        public bool Notify { get; set; }

        public Workflow Workflow { get; set; }
        public ICollection<HtmlText> HtmlText { get; set; }
        public ICollection<HtmlTextLog> HtmlTextLog { get; set; }
    }
}
