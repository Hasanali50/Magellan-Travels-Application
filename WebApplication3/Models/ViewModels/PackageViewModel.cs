using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models.ViewModels
{
    public class PackageViewModel
    {
        public String PackageName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public String Description { get; set; }
        public int cap { get; set; }
        public int amount { get; set; }
        public String picturepath { get; set; }
    }
}