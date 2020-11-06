using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class News
    {
        public int NewId { get; set; }
        public int? CategoryId { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Summary { get; set; }
        public string Keyword { get; set; }
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
        public bool? IsVideo { get; set; }
        public bool? IsPhoto { get; set; }
        public bool? IsPr { get; set; }
        public string ButDanh { get; set; }
        public string Note { get; set; }
        public int? SourceInfo { get; set; }
        public string SourceText { get; set; }
        public string StorageFolder { get; set; }
        public string AttachedFiles { get; set; }
        public bool? IsEdited { get; set; }
        public int? EditedUser { get; set; }
        public DateTime? EditedTime { get; set; }
        public int? VoteCount { get; set; }
        public int? ViewCount { get; set; }
        public bool? IsArchived { get; set; }
        public DateTime? ArchivedDate { get; set; }
        public int? Credit { get; set; }
        public DateTime? Createdate { get; set; }
        public DateTime? ApprovalRequestDate { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public int? ApprovalUser { get; set; }
        public DateTime? ReturnedDate { get; set; }
        public int? ReturnedUser { get; set; }
        public DateTime? CancelPublishDate { get; set; }
        public int? CancelPublishUser { get; set; }
        public DateTime? PublishedDate { get; set; }
        public int? PublishedUser { get; set; }
        public int? UserId { get; set; }
        public int? PortalId { get; set; }
        public string LanguageId { get; set; }
        public string Permission { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public string PhotoAttrach { get; set; }
        public bool? IsAmp { get; set; }
        public string Tacgia { get; set; }
    }
}
