using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class QlvpPhongBanChucVu
    {
        public int Id { get; set; }
        public int PhongBan { get; set; }
        public int ChucVu { get; set; }
        public bool IsDefault { get; set; }
    }
}
