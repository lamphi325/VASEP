using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class VideosByMedia
    {
        public int Id { get; set; }
        public int? Videoid { get; set; }
        public int? Mediaid { get; set; }
        public DateTime? Createdted { get; set; }
        public int? Userid { get; set; }
        public int? Portalid { get; set; }
    }
}
