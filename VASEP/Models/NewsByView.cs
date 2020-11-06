using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class NewsByView
    {
        public int Id { get; set; }
        public int? NewId { get; set; }
        public int? ViewCount { get; set; }
        public int? PortalId { get; set; }
    }
}
