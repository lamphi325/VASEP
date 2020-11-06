﻿using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class UserRelationshipPreferences
    {
        public int PreferenceId { get; set; }
        public int UserId { get; set; }
        public int RelationshipId { get; set; }
        public int DefaultResponse { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime CreatedOnDate { get; set; }
        public int LastModifiedByUserId { get; set; }
        public DateTime LastModifiedOnDate { get; set; }

        public Relationships Relationship { get; set; }
        public Users User { get; set; }
    }
}
