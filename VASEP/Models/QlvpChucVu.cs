using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class QlvpChucVu
    {
        public int Id { get; set; }
        public string ChucVu { get; set; }
        public string MoTa { get; set; }
        public int NguoiTao { get; set; }
        public DateTime NgayTao { get; set; }
        public bool? IsActive { get; set; }
        public int OrderNumber { get; set; }
        public int? PortalId { get; set; }
        public int? ModuleId { get; set; }
        public string LanguageId { get; set; }
    }
}
