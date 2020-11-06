using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class EventLogConfig
    {
        public EventLogConfig()
        {
            EventLog = new HashSet<EventLog>();
        }

        public int Id { get; set; }
        public string LogTypeKey { get; set; }
        public int? LogTypePortalId { get; set; }
        public bool LoggingIsActive { get; set; }
        public int KeepMostRecent { get; set; }
        public bool EmailNotificationIsActive { get; set; }
        public int? NotificationThreshold { get; set; }
        public int? NotificationThresholdTime { get; set; }
        public int? NotificationThresholdTimeType { get; set; }
        public string MailFromAddress { get; set; }
        public string MailToAddress { get; set; }

        public EventLogTypes LogTypeKeyNavigation { get; set; }
        public ICollection<EventLog> EventLog { get; set; }
    }
}
