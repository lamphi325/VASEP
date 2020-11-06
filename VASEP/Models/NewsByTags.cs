using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class NewsByTags
    {
        public int Id { get; set; }
        public int? NewId { get; set; }
        public string Tags { get; set; }
        public string TagsTitle { get; set; }
        public int? PortalId { get; set; }
    }
}
