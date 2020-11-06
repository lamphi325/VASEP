using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class Docs
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Quote { get; set; }
        public string Description { get; set; }
        public string Keyword { get; set; }
        public int? ViewCount { get; set; }
        public int? LikeCount { get; set; }
        public int? DislikeCount { get; set; }
        public int? DownloadCount { get; set; }
        public int? CommentCount { get; set; }
        public string CategoryIds { get; set; }
        public string Field { get; set; }
        public string Source { get; set; }
        public string Signer { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedUser { get; set; }
        public DateTime? PublishedDate { get; set; }
        public int? PublishedUser { get; set; }
        public DateTime? IssuedDate { get; set; }
        public DateTime? ValidedDate { get; set; }
        public bool? IsPublish { get; set; }
        public bool? IsDownload { get; set; }
        public byte? Type { get; set; }
        public byte? Status { get; set; }
        public int? PortalId { get; set; }
        public string LanguageId { get; set; }
    }
}
