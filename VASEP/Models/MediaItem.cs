using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class MediaItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Filename { get; set; }
        public string Forder { get; set; }
        public string MediaUrl { get; set; }
        public int? Size { get; set; }
        public string Extension { get; set; }
        public DateTime? Createddate { get; set; }
        public int? Userid { get; set; }
        public int? Portalid { get; set; }
    }
}
