using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class QlvpPhongBanDonviNguoiDung
    {
        public int Id { get; set; }
        public int PhongBan { get; set; }
        public int UserId { get; set; }
        public int Portalid { get; set; }
    }
}
