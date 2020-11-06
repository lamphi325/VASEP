using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class VsThongKeBaoCaoFiles
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public byte ItemType { get; set; }
        public string FileExtension { get; set; }
        public string FileName { get; set; }
        public string FileUrl { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUser { get; set; }
    }
}
