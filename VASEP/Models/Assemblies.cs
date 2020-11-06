using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class Assemblies
    {
        public int AssemblyId { get; set; }
        public int? PackageId { get; set; }
        public string AssemblyName { get; set; }
        public string Version { get; set; }

        public Packages Package { get; set; }
    }
}
