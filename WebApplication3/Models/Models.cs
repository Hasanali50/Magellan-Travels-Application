using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Location
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String City { get; set; }
        public String Country { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
      
    }
}