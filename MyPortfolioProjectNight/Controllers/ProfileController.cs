using MyPortfolioProjectNight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MyPortfolioProjectNight.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        DbMyPortfolioNightEntities context = new DbMyPortfolioNightEntities();
        public ActionResult Index()
        {
            var values = context.Profile.FirstOrDefault();
            return View(values);
        }


        [HttpPost]
        public ActionResult Index(Profile profile)
        {
            var existvalues = context.Profile.Find(profile.ProfileId);

            existvalues.Birthdate = profile.Birthdate;
            existvalues.Email = profile.Email;
            existvalues.Phone = profile.Phone;
            existvalues.Github = profile.Github;
            existvalues.Address = profile.Address;
            existvalues.Title = profile.Title;
            existvalues.ImageUrl = profile.ImageUrl;
            existvalues.Description = profile.Description;

            context.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}