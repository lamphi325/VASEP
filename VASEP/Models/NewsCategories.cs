using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class NewsCategories
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string EnglishName { get; set; }
        public string Description { get; set; }
        public int? TabId { get; set; }
        public int? TabIdm { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? PortalId { get; set; }
        public string LanguageId { get; set; }
        public int? ParentId { get; set; }
        public int? OrderNumber { get; set; }
    }
}
