using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class AuthCookies
    {
        public int CookieId { get; set; }
        public string CookieValue { get; set; }
        public DateTime ExpiresOn { get; set; }
        public int UserId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
