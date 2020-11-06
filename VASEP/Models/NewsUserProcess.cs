using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class NewsUserProcess
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int NewsId { get; set; }
        public short Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUser { get; set; }
        public byte? IsActive { get; set; }
    }
}
