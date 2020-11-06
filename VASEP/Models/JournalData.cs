using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class JournalData
    {
        public int JournalDataId { get; set; }
        public int JournalId { get; set; }
        public string JournalXml { get; set; }

        public Journal Journal { get; set; }
    }
}
