using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class VsPublicationValues
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string Title { get; set; }
        public string ShortTitle { get; set; }
        public string Contents { get; set; }
        public string Notes { get; set; }
        public string Value { get; set; }
        public double ValueNumber { get; set; }
        public string Currency { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUserId { get; set; }
    }
}
