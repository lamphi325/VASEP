using System;
using System.Collections.Generic;

namespace VASEP.Models
{
    public partial class Exceptions
    {
        public string ExceptionHash { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public string InnerMessage { get; set; }
        public string InnerStackTrace { get; set; }
        public string Source { get; set; }
    }
}
