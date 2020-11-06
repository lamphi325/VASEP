using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class NewsFeedback
    {
        public int NewsFeedbackId { get; set; }
        public int? ParentId { get; set; }
        public int NewsId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Address { get; set; }
        public int? OLike { get; set; }
        public int? Dislike { get; set; }
        public int? Report { get; set; }
        public string Iptrack { get; set; }
        public short? Status { get; set; }
    }
}
