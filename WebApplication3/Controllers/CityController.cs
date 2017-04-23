using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.Models.ViewModels;

namespace WebApplication3.Controllers
{
    public class CityController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CityViewModel model)
        {
            var db = Globals.GetDatabase();
            var city = new City();
            city.CityName = Globals.ToCamelCase(model.CityName);
            if (!db.Cities.Any(c => c.CityName == city.CityName))
            {
                db.Cities.Add(city);
                db.SaveChanges();
                ViewBag.Message = "City Successfully Added.";
                return View();
            }

            ModelState.AddModelError("ExistsError", "City already exists...");
            return View();


        }
        // GET: City
        public ActionResult Index()
        {
            var cities = Globals.GetDatabase().Cities.ToList();
            return View(cities);
        }

        public ActionResult Delete(string id)
        {
            var db = Globals.GetDatabase();
            var city = new City();
            city.CityName = id;
            if (db.Cities.Any(c => c.CityName == city.CityName))
            {
                db.Cities.Remove(city);
                db.SaveChanges();
                ViewBag.Message = "City Successfully Removed.";
                return View();
            }
            return View();
        }

        public ActionResult Modify(string id)
        {
            return RedirectTo(MOdif);
        }
         
    }

}
}