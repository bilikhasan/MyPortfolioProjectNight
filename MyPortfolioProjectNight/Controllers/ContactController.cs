﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolioProjectNight.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public PartialViewResult PartialContactSideBar()
        {
            return PartialView();
        }
    }
}