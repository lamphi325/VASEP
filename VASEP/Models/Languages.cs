using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class Languages
    {
        public Languages()
        {
            PortalLanguages = new HashSet<PortalLanguages>();
        }

        public int LanguageId { get; set; }
        public string CultureCode { get; set; }
        public string CultureName { get; set; }
        public string FallbackCulture { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public ICollection<PortalLanguages> PortalLanguages { get; set; }
    }
}
