using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.Models.ViewModels;

namespace WebApplication3.Controllers
{
    public class LocationsController : Controller
    {
        // GET: Locations
        public ActionResult Create() { return View(); }

        [HttpPost]
        public ActionResult Create(CreateLocationsViewModel model)
        {
            var location = new Location();
            location.Name = model.Name;
            location.City = model.Name;
            location.Country = model.Country;
            location.Latitude = model.Latitude;
            location.Longitude = model.Longitude;
            var db = new ApplicationDbContext();
            db.Locations.Add(location);
            db.SaveChanges();
            return View();
        }
    }
}