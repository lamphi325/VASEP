using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class TabVersions
    {
        public TabVersions()
        {
            TabVersionDetails = new HashSet<TabVersionDetails>();
        }

        public int TabVersionId { get; set; }
        public int TabId { get; set; }
        public int Version { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool IsPublished { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime CreatedOnDate { get; set; }
        public int LastModifiedByUserId { get; set; }
        public DateTime LastModifiedOnDate { get; set; }

        public Tabs Tab { get; set; }
        public ICollection<TabVersionDetails> TabVersionDetails { get; set; }
    }
}
