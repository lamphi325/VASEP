using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class ScheduleItemSettings
    {
        public int ScheduleId { get; set; }
        public string SettingName { get; set; }
        public string SettingValue { get; set; }

        public Schedule Schedule { get; set; }
    }
}
