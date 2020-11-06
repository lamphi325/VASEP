using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class NewsVersion
    {
        public int Id { get; set; }
        public int? CreatedUser { get; set; }
        public int NewId { get; set; }
        public int? CategoryId { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public bool? IsActive { get; set; }
        public bool? Hotcat { get; set; }
        public bool? Hotsite { get; set; }
        public short? Status { get; set; }
        public short? Unit { get; set; }
        public short? NewsKind { get; set; }
        public short? Type { get; set; }
        public string TypeUrl { get; set; }
        public string Links { get; set; }
        public string Tags { get; set; }
        public bool? IsImage { get; set; }
        public string Note { get; set; }
        public short? SourceInfo { get; set; }
        public string StorageFolder { get; set; }
        public string AttachedFiles { get; set; }
        public int? VoteCount { get; set; }
        public int? ViewCount { get; set; }
        public int? Credit { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? PublishedDate { get; set; }
        public int? PublishedUser { get; set; }
        public int? UserId { get; set; }
        public int? PortalId { get; set; }
        public DateTime? ExpiredDate { get; set; }
    }
}
