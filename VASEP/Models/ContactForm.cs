using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class ContactForm
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastNam { get; set; }
        public string Email { get; set; }
        public string Sodienthoai { get; set; }
        public string Title { get; set; }
        public string Noidung { get; set; }
        public string Diachi { get; set; }
        public string DiachiIp { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? PortalId { get; set; }
        public int? Status { get; set; }
    }
}
