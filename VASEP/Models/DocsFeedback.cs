using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class DocsFeedback
    {
        public short Id { get; set; }
        public short? DocId { get; set; }
        public string FullName { get; set; }
        public string Subject { get; set; }
        public string Contents { get; set; }
        public string Email { get; set; }
        public string Files { get; set; }
        public string Note { get; set; }
        public byte? Status { get; set; }
        public byte? PortalId { get; set; }
        public string LanguageId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public byte? CreatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte? UpdatedUserId { get; set; }
    }
}
