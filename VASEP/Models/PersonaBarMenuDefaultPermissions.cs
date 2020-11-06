using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class PersonaBarMenuDefaultPermissions
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public string RoleNames { get; set; }

        public PersonaBarMenu Menu { get; set; }
    }
}
