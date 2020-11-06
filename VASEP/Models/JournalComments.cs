using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class JournalComments
    {
        public int CommentId { get; set; }
        public int JournalId { get; set; }
        public int UserId { get; set; }
        public string Comment { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string CommentXml { get; set; }

        public Journal Journal { get; set; }
    }
}
