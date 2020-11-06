using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class TaxonomyScopeTypes
    {
        public TaxonomyScopeTypes()
        {
            TaxonomyVocabularies = new HashSet<TaxonomyVocabularies>();
        }

        public int ScopeTypeId { get; set; }
        public string ScopeType { get; set; }

        public ICollection<TaxonomyVocabularies> TaxonomyVocabularies { get; set; }
    }
}
