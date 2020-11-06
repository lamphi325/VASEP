using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class NewsNhuanBut
    {
        public int Id { get; set; }
        public int? NewId { get; set; }
        public int? Type { get; set; }
        public int? UserId { get; set; }
        public int? Credit { get; set; }
        public DateTime? Createdate { get; set; }
        public int? CreateUser { get; set; }
        public int? UserChamNhuanBut { get; set; }
        public DateTime? UserChamNhuanButDate { get; set; }
        public bool? XuatBan { get; set; }
        public int? PortalId { get; set; }
        public int? KieuNhuanBut { get; set; }
    }
}
