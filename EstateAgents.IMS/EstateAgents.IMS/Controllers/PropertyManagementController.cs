using EstateAgents.IMS.Models.PropertyManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EstateAgents.IMS.Controllers
{
    public class PropertyManagementController : Controller
    {
        public ActionResult ManageOffers()
        {
            ManageOffersViewModel model = new ManageOffersViewModel();
            return View(model);
        }

        public ActionResult ManageViewings()
        {
            ManageViewingsViewModel model = new ManageViewingsViewModel();
            return View(model);
        }
    }
}