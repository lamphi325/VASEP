using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class NewsByCategory
    {
        public long Id { get; set; }
        public int? NewsId { get; set; }
        public int? CategoryId { get; set; }
        public bool? IsMainCategory { get; set; }
    }
}
