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

        [Route("ProcessPropertyOffer/{Id}")]
        public ActionResult ProcessPropertyOffer(int Id)
        {
            ProcessPropertyOfferViewModel model = new ProcessPropertyOfferViewModel(Id);
            return View(model);
        }

        [HttpPost]
        public ActionResult ProcessPropertyOfferUpdate(ProcessPropertyOfferViewModel model)
        {
            if (ModelState.IsValid)
            {
                PropertyOfferStatus status = EstateAgentsRepository.GetPropertyOfferStatusByDescription(model.PropertyOfferStatus.ToString());
                PropertyOffers offer = EstateAgentsRepository.GetPropertyOffersById(model.OffersId);
                offer.PropertyOfferStatusId = status.Id;
                EstateAgentsRepository.UpdatePropertyOffer(offer);

                return RedirectToAction("ManageOffers", "PropertyManagement");
            }
            else
            {
                return View("ProcessPropertyOffer", model);
            }
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
                PropertyViewingStatus status = EstateAgentsRepository.GetPropertyViewingStatusByDescription(model.PropertyViewingStatus.ToString());
                PropertyViewings viewing = EstateAgentsRepository.GetPropertyViewingById(model.ViewingId);
                viewing.PropertyViewingStatusId = status.Id;
                EstateAgentsRepository.UpdatePropertyViewing(viewing);

                return RedirectToAction("ManageViewings", "PropertyManagement");
            }
            else
            {
                return View("ProcessPropertyViewing", model);
            }
        }
    }
}