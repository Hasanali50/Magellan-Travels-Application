using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.Models.ViewModels;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult RegisterCar() { return View(); }

        //[HttpPost]
        //public ActionResult RegisterCar(CarRegistrationViewModel model)
        //{
        //    var car = new Car { Make = model.Make, Name = model.Name, Model = model.Model };
        //    var dbcontext = new ApplicationDbContext();
        //    dbcontext.Cars.Add(car);
        //    dbcontext.SaveChanges();
        //    return RedirectToAction(controllerName: "Home", actionName: "Index");


        // }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}