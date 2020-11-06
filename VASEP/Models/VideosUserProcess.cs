using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class VideosUserProcess
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int VideoId { get; set; }
        public short Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUser { get; set; }
    }
}
