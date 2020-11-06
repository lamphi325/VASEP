using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class ContentWorkflowActions
    {
        public int ActionId { get; set; }
        public int ContentTypeId { get; set; }
        public string ActionType { get; set; }
        public string ActionSource { get; set; }

        public ContentTypes ContentType { get; set; }
    }
}
