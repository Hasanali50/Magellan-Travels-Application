using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.Models.ViewModels;

namespace WebApplication3.Controllers
{
    public class PackageController : Controller
    {
        [Authorize(Roles = "Administrator")]
        public ActionResult Index() {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public ActionResult Index(PackageViewModel model)
        {
            var db = Globals.GetDatabase();
            var newPackage = new Package();
            newPackage.PackageName = model.PackageName;
            newPackage.StartDate = model.StartDate;
            newPackage.EndDate = model.EndDate;
            newPackage.Description = model.Description;
            newPackage.Cap = model.Cap;
            newPackage.Amount = model.Amount;
            newPackage.PicturePath = model.PicturePath;
            db.Packages.Add(newPackage);
            db.SaveChanges();
            ViewBag.Message = "Your package has been created";
            return View();
        }


        public ActionResult Booking() { return View(); }
    }
}