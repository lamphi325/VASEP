using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class HtmlTextUsers
    {
        public int HtmlTextUserId { get; set; }
        public int ItemId { get; set; }
        public int StateId { get; set; }
        public int ModuleId { get; set; }
        public int TabId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedOnDate { get; set; }

        public HtmlText Item { get; set; }
    }
}
