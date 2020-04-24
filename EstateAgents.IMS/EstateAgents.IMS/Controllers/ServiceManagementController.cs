using EstateAgents.IMS.Models.ServiceManagement;
using EstateAgents.Library.DAL;
using System;
using System.Web.Mvc;

namespace EstateAgents.IMS.Controllers
{
    [RoutePrefix("ServiceManagement")]
    public class ServiceManagementController : Controller
    {
        public ActionResult ManageRemovals()
        {
            ManageRemovalsViewModel model = new ManageRemovalsViewModel();
            return View(model);
        }

        [Route("ProcessRemoval/{Id}")]
        public ActionResult ProcessRemoval(int Id)
        {
            PropertyRemovals p = EstateAgentsRepository.GetPropertyRemovalsByPropertyRemovalsId(Id);
            p.StaffProcessed = DateTime.Now;
            EstateAgentsRepository.UpdatePropertyRemovals(p);

            ManageRemovalsViewModel model = new ManageRemovalsViewModel();
            return View("ManageRemovals", model);
        }

        public ActionResult ManageValuations()
        {
            ManageValuationsViewModel model = new ManageValuationsViewModel();
            return View(model);
        }

        [Route("ProcessValuation/{Id}")]
        public ActionResult ProcessValuation(int Id)
        {
            PropertyValuations p = EstateAgentsRepository.GetPropertyValuationsByPropertyValuationsId(Id);
            p.StaffProcessed = DateTime.Now;
            EstateAgentsRepository.UpdatePropertyValuation(p);

            ManageValuationsViewModel model = new ManageValuationsViewModel();
            return View("ManageValuations", model);
        }

    }
}