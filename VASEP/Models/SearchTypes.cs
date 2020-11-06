using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class SearchTypes
    {
        public int SearchTypeId { get; set; }
        public string SearchTypeName { get; set; }
        public string SearchResultClass { get; set; }
        public bool? IsPrivate { get; set; }
    }
}
