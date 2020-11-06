using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class Skins
    {
        public int SkinId { get; set; }
        public int SkinPackageId { get; set; }
        public string SkinSrc { get; set; }

        public SkinPackages SkinPackage { get; set; }
    }
}
