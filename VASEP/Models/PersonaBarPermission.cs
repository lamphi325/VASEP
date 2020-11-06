﻿using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class PersonaBarPermission
    {
        public PersonaBarPermission()
        {
            PersonaBarMenuPermission = new HashSet<PersonaBarMenuPermission>();
        }

        public int PermissionId { get; set; }
        public int? MenuId { get; set; }
        public string PermissionKey { get; set; }
        public string PermissionName { get; set; }
        public int ViewOrder { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public PersonaBarMenu Menu { get; set; }
        public ICollection<PersonaBarMenuPermission> PersonaBarMenuPermission { get; set; }
    }
}
