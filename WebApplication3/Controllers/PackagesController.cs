using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models.ViewModels;

namespace WebApplication3.Controllers
{
    public class PackagesController : Controller
    {
        //GET : New Packages
        public ActionResult Create() { return View(); }

        [HttpPost]
        public ActionResult Create(PackageViewModel model)
        {
            var newPackage = new Package();
            newPackage.PackageName = Package.PackageName;
            newPackage.StartDate = Package.StartDate;
            newPackage.EndDate = Package.EndDate;
            newPackage.Description = Package.Description;
            newPackage.Cap = Package.Cap;
            newPackage.Amount = Package.Amount;
            ViewBag.Message = "Your package has been created";
            return View();
        }
    }
}