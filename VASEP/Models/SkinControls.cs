using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class SkinControls
    {
        public int SkinControlId { get; set; }
        public int PackageId { get; set; }
        public string ControlKey { get; set; }
        public string ControlSrc { get; set; }
        public string IconFile { get; set; }
        public string HelpUrl { get; set; }
        public bool SupportsPartialRendering { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public Packages Package { get; set; }
    }
}
