using MyPortfolioProjectNight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolioProjectNight.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        DbMyPortfolioNightEntities context = new DbMyPortfolioNightEntities();
        public ActionResult Index()
        {
            var values = context.About.FirstOrDefault();
            return View(values);
        }

        [HttpPost]
        public ActionResult Index(About about)
        {
            var existvalue = context.About.Find(about.AboutId);

            existvalue.Title = about.Title;
            existvalue.Description = about.Description;
            existvalue.ImageUrl = about.ImageUrl;

            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}