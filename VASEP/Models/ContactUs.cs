using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class ContactUs
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public string Subject { get; set; }
        public string Contents { get; set; }
        public bool? Status { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? PortalId { get; set; }
        public string LanguageId { get; set; }
    }
}
