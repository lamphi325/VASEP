using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class PackageDependencies
    {
        public int PackageDependencyId { get; set; }
        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public string Version { get; set; }

        public Packages Package { get; set; }
    }
}
