using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.Models.ViewModels;

namespace WebApplication3.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PhotoSave(GalleryViewModel model, HttpPostedFileBase file)
        {
            var db = Globals.GetDatabase();
            var gallery = new Gallery();
            
            var fileName = file.FileName;
            string path = System.IO.Path.Combine(Server.MapPath("~/Img"), fileName);
            file.SaveAs(path);
            string dbPath = System.IO.Path.Combine("~/Img", fileName);
            gallery.PictureDesc = model.PictureDesc;
            gallery.PicturePath = dbPath;
            db.Gallery.Add(gallery);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}