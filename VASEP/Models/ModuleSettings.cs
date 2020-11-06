using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class ModuleSettings
    {
        public int ModuleId { get; set; }
        public string SettingName { get; set; }
        public string SettingValue { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public Modules Module { get; set; }
    }
}
