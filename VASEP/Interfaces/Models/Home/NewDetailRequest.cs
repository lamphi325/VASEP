using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VASEP.Interfaces.Models.Home
{
    public class NewDetailRequest
    {
        [Required]
        public int NewId { get; set; }

        [Required]
        public int PortalId { get; set; }
    }
}
