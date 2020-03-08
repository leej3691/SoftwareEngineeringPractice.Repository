using EstateAgents.IMS.Models.ServiceManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EstateAgents.IMS.Controllers
{
    public class ServiceManagementController : Controller
    {
        public ActionResult ManageBrokers()
        {
            ManageBrokersViewModel model = new ManageBrokersViewModel();
            return View(model);
        }

        public ActionResult ManageRemovals()
        {
            ManageRemovalsViewModel model = new ManageRemovalsViewModel();
            return View(model);
        }

        public ActionResult ManageValuations()
        {
            ManageValuationsViewModel model = new ManageValuationsViewModel();
            return View(model);
        }
    }
}