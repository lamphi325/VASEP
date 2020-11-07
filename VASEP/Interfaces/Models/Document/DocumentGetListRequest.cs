using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VASEP.Interfaces.Models.Document
{
    public class DocumentGetListRequest
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string CategoryIds { get; set; } = "0";
        public bool IsPublish { get; set; } = true;
        public string IssuedDate { get; set; }
        public int CreatedUser { get; set; } = 1;
        public int Field { get; set; } = 0;
        public int Source { get; set; } = 0;
        public int Type { get; set; } = 0;
        public int PortalId { get; set; } = 0;

        [Required]
        public string Language { get; set; } = "vi-VN";

        [Required]
        public int PageIndex { get; set; } = 1;

        [Required]
        public int PageSize { get; set; } = 20;

        public string Status { get; set; } = "2";
        public string IsRole { get; set; } = "-1";
    }
}
