using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class EventLog
    {
        public string LogGuid { get; set; }
        public string LogTypeKey { get; set; }
        public int? LogConfigId { get; set; }
        public int? LogUserId { get; set; }
        public string LogUserName { get; set; }
        public int? LogPortalId { get; set; }
        public string LogPortalName { get; set; }
        public DateTime LogCreateDate { get; set; }
        public string LogServerName { get; set; }
        public string LogProperties { get; set; }
        public bool? LogNotificationPending { get; set; }
        public long LogEventId { get; set; }
        public string ExceptionHash { get; set; }

        public EventLogConfig LogConfig { get; set; }
        public EventLogTypes LogTypeKeyNavigation { get; set; }
        public ExceptionEvents ExceptionEvents { get; set; }
    }
}
