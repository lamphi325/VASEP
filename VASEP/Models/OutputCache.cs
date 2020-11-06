using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class OutputCache
    {
        public string CacheKey { get; set; }
        public int ItemId { get; set; }
        public string Data { get; set; }
        public DateTime Expiration { get; set; }
    }
}
