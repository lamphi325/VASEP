using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class NewsByVideo
    {
        public int Id { get; set; }
        public int? NewId { get; set; }
        public int? VideoId { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? PortalId { get; set; }
    }
}
