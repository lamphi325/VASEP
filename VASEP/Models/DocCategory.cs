using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class DocCategory
    {
        public int Id { get; set; }
        public int? DocId { get; set; }
        public int? CategoryId { get; set; }
    }
}
