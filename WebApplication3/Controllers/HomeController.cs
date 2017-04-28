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

        public ActionResult Package() {
            var packagelist = Globals.GetDatabase().Packages.ToList();
            return View(packagelist);

        }
        public ActionResult Index()
        {
            List<SelectListItem> ObjItem = new List<SelectListItem>()
            {
                new SelectListItem{Text="Select", Value= "0", Selected=true},
                new SelectListItem{Text="Murre", Value= "1"},
                new SelectListItem{Text="Kashmir", Value= "2"},
                new SelectListItem{Text="Lahore", Value= "3"},
                new SelectListItem{Text="Kaghan", Value= "4"},
            };
            ViewBag.ListItem = ObjItem;
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

  
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(FeedBackViewModel model)
        {
            var db = Globals.GetDatabase();
            var newFeedBack = new FeedBack();
            newFeedBack.FeedBackName = model.FeedBackName;
            newFeedBack.FeedBackEmail = model.FeedBackEmail;
            newFeedBack.FeedBackDesc = model.FeedBackDesc;
            if (newFeedBack.FeedBackName != null && newFeedBack.FeedBackEmail != null && newFeedBack.FeedBackDesc != null)
            {
                db.Feedbacks.Add(newFeedBack);
                db.SaveChanges();
            }
            else
                ModelState.AddModelError("NewFeedBack", "Please Enter All The Details");
            return View();
        }

        public ActionResult Gallery()
        {
            var Pictures = Globals.GetDatabase().Gallery.ToList();
            return View(Pictures);
        }


        public ActionResult Review()
        {
            ViewBag.Message = "Leave us a review. :)";

            return View();
        }
    }
}