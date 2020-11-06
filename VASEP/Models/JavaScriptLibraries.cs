using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class JavaScriptLibraries
    {
        public int JavaScriptLibraryId { get; set; }
        public int PackageId { get; set; }
        public string LibraryName { get; set; }
        public string Version { get; set; }
        public string FileName { get; set; }
        public string ObjectName { get; set; }
        public int PreferredScriptLocation { get; set; }
        public string Cdnpath { get; set; }

        public Packages Package { get; set; }
    }
}
