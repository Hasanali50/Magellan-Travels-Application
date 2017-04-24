﻿using System;
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
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Gallery()
        {
            ViewBag.Message = "Welcome to the gallery";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}