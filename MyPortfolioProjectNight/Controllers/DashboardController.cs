using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolioProjectNight.Models;

namespace MyPortfolioProjectNight.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        DbMyPortfolioNightEntities context = new DbMyPortfolioNightEntities();
        public ActionResult Index()
        {
            ViewBag.EducationCount = context.Education.Count();
            ViewBag.SkillCount = context.Skill.Count(); 
            ViewBag.ExperienceCount = context.Experience.Count();
            ViewBag.ServiceCount = context.Service.Count();
            ViewBag.SocialMediaCount = context.SocialMedia.Count();
            ViewBag.MessageCount = context.Contact.Count();

            return View(); 
        }
    }
}