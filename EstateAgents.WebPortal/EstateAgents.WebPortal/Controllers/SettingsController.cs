using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EstateAgents.WebPortal.Controllers
{
    public class SettingsController : Controller
    {
        // GET: Settings
        public ActionResult PrivacyPolicy()
        {
            return View();
        }

        public ActionResult ServiceAgreement()
        {
            return View();
        }

        public ActionResult TermsOfUse()
        {
            return View();
        }

        public ActionResult YourDetails()
        {
            return View();
        }

        public ActionResult FAQ()
        {
            return View();
        }
    }
}