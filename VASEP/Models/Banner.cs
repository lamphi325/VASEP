using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class Banner
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int KieuBanner { get; set; }
        public string Imglink { get; set; }
        public int Vitri { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
        public int PortalId { get; set; }
        public int UserId { get; set; }
        public bool? Visible { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? Ordernumber { get; set; }
        public string Link { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public string Contact { get; set; }
        public int? Click { get; set; }
        public int? SView { get; set; }
    }
}
