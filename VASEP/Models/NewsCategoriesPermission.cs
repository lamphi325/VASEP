using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class NewsCategoriesPermission
    {
        public long Id { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public int RoleId { get; set; }
    }
}
