using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class BannerVitri
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string Images { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public int? ModuleId { get; set; }
        public int? Portalid { get; set; }
    }
}
