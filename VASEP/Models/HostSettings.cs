using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class HostSettings
    {
        public string SettingName { get; set; }
        public string SettingValue { get; set; }
        public bool SettingIsSecure { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
    }
}
