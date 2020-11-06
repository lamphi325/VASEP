using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class NewsSettings
    {
        public int Id { get; set; }
        public int? NewId { get; set; }
        public int? OrderNumber { get; set; }
        public int? Type { get; set; }
        public int? PortalId { get; set; }
    }
}
