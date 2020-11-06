using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class Authentication
    {
        public int AuthenticationId { get; set; }
        public int PackageId { get; set; }
        public string AuthenticationType { get; set; }
        public bool IsEnabled { get; set; }
        public string SettingsControlSrc { get; set; }
        public string LoginControlSrc { get; set; }
        public string LogoffControlSrc { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public Packages Package { get; set; }
    }
}
