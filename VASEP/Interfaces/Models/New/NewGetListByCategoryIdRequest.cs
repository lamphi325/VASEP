using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VASEP.Interfaces.Models.New
{
    public class NewGetListByCategoryIdRequest
    {
        public string SubtractIds { get; set; }
        public int CategoryId { get; set; } = 0;

        [Required]
        public int PortalId { get; set; } = 0;

        [Required]
        public string Language { get; set; } = "vi-VN";

        [Required]
        public int PageIndex { get; set; } = 1;

        [Required]
        public int PageSize { get; set; } = 20;

        [Required]
        public bool IsImage { get; set; }
    }
}
