using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class QlvpPhongBan
    {
        public int Id { get; set; }
        public string TenPhongBan { get; set; }
        public int? ParentId { get; set; }
        public string MoTa { get; set; }
        public int NguoiTao { get; set; }
        public DateTime NgayTao { get; set; }
        public bool? IsActive { get; set; }
        public int OrderNumber { get; set; }
        public int? PortalId { get; set; }
        public int? ModuleId { get; set; }
        public string LanguageId { get; set; }
        public string TenVietTat { get; set; }
        public bool? ShowonMenu { get; set; }
        public int? TabId { get; set; }
        public string Link { get; set; }
        public string Email { get; set; }
    }
}
