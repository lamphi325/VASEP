using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class Subscribe
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsSend { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
        public int? PortalId { get; set; }
        public string LanguageId { get; set; }
    }
}
