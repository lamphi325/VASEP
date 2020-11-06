using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class ContentItemsTags
    {
        public int ContentItemTagId { get; set; }
        public int ContentItemId { get; set; }
        public int TermId { get; set; }

        public ContentItems ContentItem { get; set; }
        public TaxonomyTerms Term { get; set; }
    }
}
