using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class CoreMessagingSubscriptionTypes
    {
        public CoreMessagingSubscriptionTypes()
        {
            CoreMessagingSubscriptions = new HashSet<CoreMessagingSubscriptions>();
        }

        public int SubscriptionTypeId { get; set; }
        public string SubscriptionName { get; set; }
        public string FriendlyName { get; set; }
        public int? DesktopModuleId { get; set; }

        public ICollection<CoreMessagingSubscriptions> CoreMessagingSubscriptions { get; set; }
    }
}
