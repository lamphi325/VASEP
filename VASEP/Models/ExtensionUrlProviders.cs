﻿using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class ExtensionUrlProviders
    {
        public int ExtensionUrlProviderId { get; set; }
        public string ProviderName { get; set; }
        public string ProviderType { get; set; }
        public string SettingsControlSrc { get; set; }
        public bool IsActive { get; set; }
        public bool RewriteAllUrls { get; set; }
        public bool RedirectAllUrls { get; set; }
        public bool ReplaceAllUrls { get; set; }
        public int? DesktopModuleId { get; set; }
    }
}
