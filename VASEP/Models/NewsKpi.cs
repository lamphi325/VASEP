using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class NewsKpi
    {
        public int Id { get; set; }
        public string Thang { get; set; }
        public DateTime? Thangfull { get; set; }
        public int? Pvsobai { get; set; }
        public int? Pvsoview { get; set; }
        public int? PvuserId { get; set; }
        public DateTime? Pvcreateddate { get; set; }
        public int? YeucauBai { get; set; }
        public int? YeucauView { get; set; }
        public int? YeuCauUserId { get; set; }
        public DateTime? YeuCaucreateddate { get; set; }
        public int? PortalId { get; set; }
    }
}
