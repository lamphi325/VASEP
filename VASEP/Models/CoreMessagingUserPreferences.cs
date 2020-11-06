﻿using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class CoreMessagingUserPreferences
    {
        public int UserPreferenceId { get; set; }
        public int PortalId { get; set; }
        public int UserId { get; set; }
        public int MessagesEmailFrequency { get; set; }
        public int NotificationsEmailFrequency { get; set; }
    }
}
