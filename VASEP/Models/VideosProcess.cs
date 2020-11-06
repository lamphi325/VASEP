using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class VideosProcess
    {
        public int Id { get; set; }
        public int VideoId { get; set; }
        public int StatusId { get; set; }
        public string ProcessName { get; set; }
        public string Comment { get; set; }
        public int? ByUser { get; set; }
        public int? ToUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? VersionId { get; set; }
        public string Iptrack { get; set; }
    }
}
