using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class QlvpUserWf
    {
        public int Id { get; set; }
        public string TenLuong { get; set; }
        public int? PhongBan { get; set; }
        public int NguoiGui { get; set; }
        public string NguoiNhan { get; set; }
        public short? TrangThaiDich { get; set; }
        public short LoaiWf { get; set; }
        public bool? IsDefault { get; set; }
        public string MoTa { get; set; }
        public int NguoiTao { get; set; }
        public DateTime NgayTao { get; set; }
        public bool? IsActive { get; set; }
        public int OrderNumber { get; set; }
        public int? PortalId { get; set; }
        public int? ModuleId { get; set; }
        public string LanguageId { get; set; }
        public string IconSmall { get; set; }
        public string IconLarge { get; set; }
    }
}
