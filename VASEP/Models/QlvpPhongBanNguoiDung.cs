using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class QlvpPhongBanNguoiDung
    {
        public int Id { get; set; }
        public int PhongBan { get; set; }
        public int ChucVu { get; set; }
        public int UserId { get; set; }
        public bool LaNguoiKy { get; set; }
        public bool LaNguoiNhanVb { get; set; }
        public bool LaLanhDao { get; set; }
        public int PortalId { get; set; }
    }
}
