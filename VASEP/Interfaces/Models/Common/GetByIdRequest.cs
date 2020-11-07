using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VASEP.Interfaces.Models.Common
{
    public class GetByIdRequest
    {
        [Required]
        public int Id { get; set; }
    }
}
