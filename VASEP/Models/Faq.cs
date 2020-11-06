using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class Faq
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Image { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? Sort { get; set; }
        public int? PortalId { get; set; }
        public string LanguageId { get; set; }
        public string AnswerUserId { get; set; }
        public string AnswerUsername { get; set; }
        public bool? IsUserDefault { get; set; }
        public string DefaultAnswerName { get; set; }
        public string DefaultAnswerImage { get; set; }
    }
}
