using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class HtmlText
    {
        public HtmlText()
        {
            HtmlTextLog = new HashSet<HtmlTextLog>();
            HtmlTextUsers = new HashSet<HtmlTextUsers>();
        }

        public int ModuleId { get; set; }
        public int ItemId { get; set; }
        public string Content { get; set; }
        public int? Version { get; set; }
        public int? StateId { get; set; }
        public bool? IsPublished { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public string Summary { get; set; }

        public Modules Module { get; set; }
        public WorkflowStates State { get; set; }
        public ICollection<HtmlTextLog> HtmlTextLog { get; set; }
        public ICollection<HtmlTextUsers> HtmlTextUsers { get; set; }
    }
}
