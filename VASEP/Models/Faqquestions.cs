using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class Faqquestions
    {
        public int Id { get; set; }
        public int? Faqid { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Contents { get; set; }
        public bool? IsPublic { get; set; }
        public int? Point { get; set; }
        public string LanguageId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? Sort { get; set; }
        public int? PortalId { get; set; }
        public int? Status { get; set; }
    }
}
