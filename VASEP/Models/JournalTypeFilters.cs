﻿using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class JournalTypeFilters
    {
        public int JournalTypeFilterId { get; set; }
        public int PortalId { get; set; }
        public int ModuleId { get; set; }
        public int JournalTypeId { get; set; }
    }
}
