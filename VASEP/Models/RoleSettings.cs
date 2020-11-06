using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class RoleSettings
    {
        public int RoleSettingId { get; set; }
        public int RoleId { get; set; }
        public string SettingName { get; set; }
        public string SettingValue { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime CreatedOnDate { get; set; }
        public int LastModifiedByUserId { get; set; }
        public DateTime LastModifiedOnDate { get; set; }
    }
}
