using EstateAgents.WebPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EstateAgents.WebPortal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ContactViewModel model = new ContactViewModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult ContactEnquiry(ContactViewModel model)
        {

            return View();
        }
    }
}