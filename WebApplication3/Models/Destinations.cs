using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.Web.Mvc;

namespace WebApplication3.Models
{
    public class Destinations
    {
        public Destinations()
        {
            SubjectList = new List<SelectListItem>();
        }
        [DisplayName("Subjects")]
        public List<SelectListItem> SubjectList { get; set; }
    }
}