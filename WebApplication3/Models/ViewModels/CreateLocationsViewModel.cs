using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models.ViewModels
{
    public class CreateLocationsViewModel
    {
        public String Name { get; set; }
        public String City { get; set; }
        public String Country { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
    }
}