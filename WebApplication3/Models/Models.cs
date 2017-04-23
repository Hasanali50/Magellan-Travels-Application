using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class City
    {
        public City()
        {
            Locations = new HashSet<Location>();
        }
        [Key]
        [Required]
        public String CityName { get; set; }
        public ICollection<Location> Locations { get; set; }
    }

    public class Location
    {
        public Location() {
            PackageLocations = new HashSet<PackageLocations>();
        }

        public int LocationID { get; set; }
        public String LocationName { get; set; }
        public City City { get; set; }
        public ICollection<PackageLocations> PackageLocations { get; set; }
    }

    public class Package
    {
        public Package() {
            PackageLocations = new HashSet<PackageLocations>();
        }
        public int PackageID { get; set; }
        public String PackageName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public String Description { get; set; }
        public int cap { get; set; }
        public int amount { get; set; }
        public String picturepath { get; set; }
        public ICollection<PackageLocations> PackageLocations { get; set; } 
    }

    public class PackageLocations {
        public int ID { get; set; }
        public Location LocationOfPackage { get; set; }
        public Package PackageBelongingTo { get; set; }
        public int Order { get; set; }
    }

    public class Customer : ApplicationUser
    {
      
        public String CNIC { get; set; }

    }

    public class Booking
    {
        public int BookingID { get; set; }
        public Customer BookedBy { get; set; }
        public Package PackageSelected { get; set; }
        public int NumberOfPeople { get; set; }
        public double TotalAmount { get; set; }
    }

    public class Payment
    {
        public int PaymentID { get; set; }
        public DateTime PayementDate { get; set; }
        public double PaymentAmount { get; set; }
        public Customer MadeBy { get; set; }
        public Booking PaidAgainst { get; set; }


    }




}