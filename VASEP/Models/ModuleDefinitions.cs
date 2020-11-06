using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class ModuleDefinitions
    {
        public ModuleDefinitions()
        {
            ModuleControls = new HashSet<ModuleControls>();
            Modules = new HashSet<Modules>();
        }

        public int ModuleDefId { get; set; }
        public string FriendlyName { get; set; }
        public int DesktopModuleId { get; set; }
        public int DefaultCacheTime { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public string DefinitionName { get; set; }

        public DesktopModules DesktopModule { get; set; }
        public ICollection<ModuleControls> ModuleControls { get; set; }
        public ICollection<Modules> Modules { get; set; }
    }
}
