using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class Faqanswers
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int QuestionId { get; set; }
        public string Content { get; set; }
        public bool? IsPublic { get; set; }
        public string LanguageId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? Sort { get; set; }
        public int? PortalId { get; set; }
        public string AnswerName { get; set; }
        public string AnswerImage { get; set; }
    }
}
