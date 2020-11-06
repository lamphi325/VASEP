using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class Videos
    {
        public int Id { get; set; }
        public int Danhmuc { get; set; }
        public string Title { get; set; }
        public string Avatar { get; set; }
        public string LinkVideos { get; set; }
        public string Tomtat { get; set; }
        public string Noidung { get; set; }
        public bool IsYoutube { get; set; }
        public bool IsHot { get; set; }
        public bool IsHotcat { get; set; }
        public bool IsNotes { get; set; }
        public bool? IsTruyenHinh { get; set; }
        public int? Luotxem { get; set; }
        public int TrangThai { get; set; }
        public string Butdanh { get; set; }
        public string Linknguon { get; set; }
        public string Tags { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserId { get; set; }
        public int? ApproveUser { get; set; }
        public DateTime? ApproveDate { get; set; }
        public int? PublicUser { get; set; }
        public DateTime? PublicDate { get; set; }
        public bool? IsEdited { get; set; }
        public int? EditedUser { get; set; }
        public DateTime? EditedTime { get; set; }
        public int? PortalId { get; set; }
    }
}
