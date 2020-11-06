using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class PackageTypes
    {
        public PackageTypes()
        {
            Packages = new HashSet<Packages>();
        }

        public string PackageType { get; set; }
        public string Description { get; set; }
        public int SecurityAccessLevel { get; set; }
        public string EditorControlSrc { get; set; }
        public bool SupportsSideBySideInstallation { get; set; }

        public ICollection<Packages> Packages { get; set; }
    }
}
