﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.Models.ViewModels;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {

        /*    public ActionResult CreateAdmin()
         {

         // var manager = ApplicationUserManager();
             string Email = "adminstrator@magellantravels.com";
             string password = "magellantravels2015.";
             var user = new ApplicationUser { UserName = Email, Email = Email };
             IdentityResult i = ApplicationUserManager.Create(user, password);
             return View(nameof(Index));
         }*/

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
        [AllowAnonymous]
        public ActionResult Package()
        {
            var packagelist = Globals.GetDatabase().Packages.ToList();
            return View(packagelist);

        }
        [AllowAnonymous]
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
        [AllowAnonymous]
        public ActionResult About()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page.";

            return View();
        }

        [AllowAnonymous]
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
                string emailFrom = "magellantravels15@gmail.com";
                string password = "magellantravels2015.";
                string emailTo = "magellantravels15@gmail.com";
                string subject = "Feedback from " + newFeedBack.FeedBackName + " having email " + newFeedBack.FeedBackEmail;
                string body = newFeedBack.FeedBackDesc;
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(emailFrom);
                mail.To.Add(emailTo);

                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = false;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(emailFrom, password);
                smtp.EnableSsl = true;
                smtp.Send(mail);

                db.Feedbacks.Add(newFeedBack);
                db.SaveChanges();

            }
            else
                ModelState.AddModelError("NewFeedBack", "Please Enter All The Details");
            return View();


        }
        [AllowAnonymous]
        public ActionResult Gallery()
        {
            var Pictures = Globals.GetDatabase().Gallery.ToList();
            return View(Pictures);
        }

        [AllowAnonymous]
        public ActionResult Review()
        {
            ViewBag.Message = "Leave us a review. :)";

            return View();
        }
    }
}