using EstateAgents.IMS.Models.PropertyManagement;
using EstateAgents.Library.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EstateAgents.IMS.Controllers
{
    [RoutePrefix("PropertyManagement")]
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

        [Route("ProcessPropertyViewing/{Id}")]
        public ActionResult ProcessPropertyViewing(int Id)
        {
            ProcessPropertyViewingViewModel model = new ProcessPropertyViewingViewModel(Id);
            return View(model);
        }

        [HttpPost]
        public ActionResult ProcessPropertyViewingUpdate(ProcessPropertyViewingViewModel model)
        {
            if (ModelState.IsValid)
            {
                

                EstateAgentsRepository.UpdatePropertyViewing(model.PropertyViewing);

                return RedirectToAction("ManageViewings", "PropertyManagement");
            }
            else
            {
                return View("ProcessPropertyViewing", model);
            }
        }
    }
}