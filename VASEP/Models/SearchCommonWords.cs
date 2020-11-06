using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class SearchCommonWords
    {
        public int CommonWordId { get; set; }
        public string CommonWord { get; set; }
        public string Locale { get; set; }
    }
}
