using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class ContentTypes
    {
        public ContentTypes()
        {
            ContentItems = new HashSet<ContentItems>();
            ContentWorkflowActions = new HashSet<ContentWorkflowActions>();
        }

        public int ContentTypeId { get; set; }
        public string ContentType { get; set; }

        public ICollection<ContentItems> ContentItems { get; set; }
        public ICollection<ContentWorkflowActions> ContentWorkflowActions { get; set; }
    }
}
