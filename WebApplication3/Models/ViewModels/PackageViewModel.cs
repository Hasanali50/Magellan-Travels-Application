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
        public int Cap { get; set; }
        public int Amount { get; set; }
        public String PicturePath { get; set; }
    }
}