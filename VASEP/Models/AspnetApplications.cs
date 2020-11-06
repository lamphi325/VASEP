using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class AspnetApplications
    {
        public AspnetApplications()
        {
            AspnetMembership = new HashSet<AspnetMembership>();
            AspnetUsers = new HashSet<AspnetUsers>();
        }

        public string ApplicationName { get; set; }
        public string LoweredApplicationName { get; set; }
        public Guid ApplicationId { get; set; }
        public string Description { get; set; }

        public ICollection<AspnetMembership> AspnetMembership { get; set; }
        public ICollection<AspnetUsers> AspnetUsers { get; set; }
    }
}
