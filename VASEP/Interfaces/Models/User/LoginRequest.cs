using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VASEP.Interfaces.Models.User
{
    public class LoginRequest
    {
        [MaxLength(50)]
        [Required]
        public string UserName { get; set; }

        [MaxLength(50)]
        [Required]
        public string Password { get; set; }
    }
}
