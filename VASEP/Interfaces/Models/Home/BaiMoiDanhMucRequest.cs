using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VASEP.Interfaces.Models.Home
{
    public class BaiMoiDanhMucRequest
    {
        public string SubtractIds { get; set; }

        public int CategoryId { get; set; } = 0;

        [Required]
        public int PortalId { get; set; } = 0;

        [Required]
        public int Count { get; set; }

        [Required]
        public bool IsImage { get; set; }
    }
}
