using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class VsThongkeBaoCao
    {
        public int Id { get; set; }
        public string Avatar { get; set; }
        public string Title { get; set; }
        public string ShortTitle { get; set; }
        public string Description { get; set; }
        public string Contents { get; set; }
        public int? AuthorId { get; set; }
        public string Tags { get; set; }
        public string Source { get; set; }
        public byte? Kind { get; set; }
        public int CategoryId { get; set; }
        public byte? TypeId { get; set; }
        public bool? IsPublish { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? PublishedDate { get; set; }
        public int? PublishedUserId { get; set; }
        public int? CountView { get; set; }
        public int? CountDownload { get; set; }
        public int? PortalId { get; set; }
        public string LanguageId { get; set; }
    }
}
