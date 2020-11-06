using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class CoreMessagingSubscriptions
    {
        public int SubscriptionId { get; set; }
        public int UserId { get; set; }
        public int? PortalId { get; set; }
        public int SubscriptionTypeId { get; set; }
        public string ObjectKey { get; set; }
        public string ObjectData { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOnDate { get; set; }
        public int? ModuleId { get; set; }
        public int? TabId { get; set; }

        public Modules Module { get; set; }
        public Portals Portal { get; set; }
        public CoreMessagingSubscriptionTypes SubscriptionType { get; set; }
        public Users User { get; set; }
    }
}
