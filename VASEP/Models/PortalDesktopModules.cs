using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class PortalDesktopModules
    {
        public PortalDesktopModules()
        {
            DesktopModulePermission = new HashSet<DesktopModulePermission>();
        }

        public int PortalDesktopModuleId { get; set; }
        public int PortalId { get; set; }
        public int DesktopModuleId { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public DesktopModules DesktopModule { get; set; }
        public Portals Portal { get; set; }
        public ICollection<DesktopModulePermission> DesktopModulePermission { get; set; }
    }
}
