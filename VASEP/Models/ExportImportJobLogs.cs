using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class ExportImportJobLogs
    {
        public int JobLogId { get; set; }
        public int JobId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int Level { get; set; }
        public DateTime CreatedOnDate { get; set; }

        public ExportImportJobs Job { get; set; }
    }
}
