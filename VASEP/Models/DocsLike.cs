using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class DocsLike
    {
        public int Id { get; set; }
        public int? DocsId { get; set; }
        public bool? IsLike { get; set; }
        public bool? IsDislike { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
