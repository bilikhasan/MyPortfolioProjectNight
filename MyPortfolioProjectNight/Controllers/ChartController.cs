using MyPortfolioProjectNight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolioProjectNight.Controllers
{
    public class ChartController : Controller
    {
        DbMyPortfolioNightEntities context = new DbMyPortfolioNightEntities();

        public ActionResult Index()
        {
            var skills = context.Skill.ToList();
            
            var skillNames = context.Skill.Select(x=>x.SkillName).ToList();
            var skillRates = context.Skill.Select(x=>x.Rate).ToList();

            ViewBag.SkillNames = skillNames;
            ViewBag.SkillRates = skillRates;

            return View();
        }
    }
}