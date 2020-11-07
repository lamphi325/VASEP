using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VASEP.Interfaces.Models.Media
{
    public class VideoShowRequest
    {
        [MaxLength(500)]
        public string SubtractIds { get; set; }

        public int Danhmuc { get; set; } = 0;

        [Required]
        public bool Istruyenhinh { get; set; }

        [Required]
        public int PortalId { get; set; } = 0;

        [Required]
        public int PageIndex { get; set; } = 1;

        [Required]
        public int PageSize { get; set; } = 20;
    }
}
