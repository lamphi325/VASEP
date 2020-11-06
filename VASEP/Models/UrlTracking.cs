﻿using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class UrlTracking
    {
        public UrlTracking()
        {
            UrlLog = new HashSet<UrlLog>();
        }

        public int UrlTrackingId { get; set; }
        public int? PortalId { get; set; }
        public string Url { get; set; }
        public string UrlType { get; set; }
        public int Clicks { get; set; }
        public DateTime? LastClick { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool LogActivity { get; set; }
        public bool? TrackClicks { get; set; }
        public int? ModuleId { get; set; }
        public bool NewWindow { get; set; }

        public Portals Portal { get; set; }
        public ICollection<UrlLog> UrlLog { get; set; }
    }
}
