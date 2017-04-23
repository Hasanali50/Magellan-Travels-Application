using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.Models.ViewModels;

namespace WebApplication3.Controllers
{
    public class CityController : Controller
    {
        public ActionResult Create() {
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
            var city = db.Cities.Find(id);

            if (city.CityName == null)
                return RedirectToAction(nameof(Index));
            else
                db.Cities.Remove(city);
                db.SaveChanges();
                ViewBag.Message = "City Successfully Removed.";
                return RedirectToAction(nameof(Index));
            }
      //     return RedirectToAction(nameof(Index));
        

        public ActionResult Modify(string id)
        {
            var city = Globals.GetDatabase().Cities.Find(id);
            if (city != null)
            {
                return View(city);
            }
            else
                return RedirectToAction(nameof(Index));

        }

        [HttpPost]
        public ActionResult Modify(string Id, City NewCity)
        {
            var db = Globals.GetDatabase();
            if (!ModelState.IsValid)
                return View(Id);
            var OldCity = db.Cities.Find(Id);
            db.Cities.Remove(OldCity);
            db.Cities.Add(NewCity);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }

}
