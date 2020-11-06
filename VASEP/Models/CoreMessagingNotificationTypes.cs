using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class CoreMessagingNotificationTypes
    {
        public CoreMessagingNotificationTypes()
        {
            CoreMessagingMessages = new HashSet<CoreMessagingMessages>();
            CoreMessagingNotificationTypeActions = new HashSet<CoreMessagingNotificationTypeActions>();
        }

        public int NotificationTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Ttl { get; set; }
        public int? DesktopModuleId { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public bool IsTask { get; set; }

        public DesktopModules DesktopModule { get; set; }
        public ICollection<CoreMessagingMessages> CoreMessagingMessages { get; set; }
        public ICollection<CoreMessagingNotificationTypeActions> CoreMessagingNotificationTypeActions { get; set; }
    }
}
