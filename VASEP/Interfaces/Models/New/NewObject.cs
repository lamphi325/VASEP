using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VASEP.Interfaces.Models.New
{
    public class NewObject
    {
        public int NewId { get; set; }
        public int Type { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Tacgia { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }
        public string Summary { get; set; }
        public DateTime? PublishedDate { get; set; }
        public int ViewCount { get; set; }
        public string Links { get; set; }
        public int TotalRecords { get; set; }
    }
}
