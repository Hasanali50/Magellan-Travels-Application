using Microsoft.AspNet.Identity.Owin;
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
        public ActionResult Create(LocationsViewModel model)
        {
            var location = new Location();
            location.LocationName = model.LocationName;
            location.City = model.City;
            var db = HttpContext.GetOwinContext().Get<ApplicationDbContext>();
            db.Locations.Add(location);
            db.SaveChanges();
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }


    }
}