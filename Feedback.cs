using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Models
{
    public class Feedback
    {
        public string EnrollmentNo { get; set; }
        public string StudentName { get; set; }
        public string Subject { get; set; }
        public int Rating { get; set; }
        public string Comments { get; set; }

    }
}
