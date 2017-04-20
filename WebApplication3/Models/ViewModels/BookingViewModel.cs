using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models.ViewModels
{
    public class BookingViewModel
    {
        public String BookedBy { get; set; }
        public String PackageSelected { get; set; }
        public int NumberOfPeople { get; set; }
        public double TotalAmount { get; set; }
    }
}