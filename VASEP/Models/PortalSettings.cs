using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class PortalSettings
    {
        public int PortalSettingId { get; set; }
        public int PortalId { get; set; }
        public string SettingName { get; set; }
        public string SettingValue { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public string CultureCode { get; set; }
        public bool IsSecure { get; set; }

        public Portals Portal { get; set; }
    }
}
