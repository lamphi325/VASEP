using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class LichLamViec
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Contents { get; set; }
        public string Note { get; set; }
        public string Files { get; set; }
        public int? Year { get; set; }
        public int? Week { get; set; }
        public bool? Status { get; set; }
        public int? PortalId { get; set; }
        public string LanguageId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
