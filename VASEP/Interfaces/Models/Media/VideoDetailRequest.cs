using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VASEP.Interfaces.Models.Media
{
    public class VideoDetailRequest
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int PortalId { get; set; }
    }
}
