using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class TaxonomyVocabularyTypes
    {
        public TaxonomyVocabularyTypes()
        {
            TaxonomyVocabularies = new HashSet<TaxonomyVocabularies>();
        }

        public int VocabularyTypeId { get; set; }
        public string VocabularyType { get; set; }

        public ICollection<TaxonomyVocabularies> TaxonomyVocabularies { get; set; }
    }
}
