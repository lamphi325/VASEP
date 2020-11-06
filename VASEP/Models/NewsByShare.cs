using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class NewsByShare
    {
        public int Id { get; set; }
        public int NewId { get; set; }
        public string LinkShare { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UserId { get; set; }
        public int? Count { get; set; }
    }
}
