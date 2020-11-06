using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class UserRelationships
    {
        public int UserRelationshipId { get; set; }
        public int UserId { get; set; }
        public int RelatedUserId { get; set; }
        public int RelationshipId { get; set; }
        public int Status { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime CreatedOnDate { get; set; }
        public int LastModifiedByUserId { get; set; }
        public DateTime LastModifiedOnDate { get; set; }

        public Users RelatedUser { get; set; }
        public Relationships Relationship { get; set; }
        public Users User { get; set; }
    }
}
