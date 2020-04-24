using EstateAgents.Library.DAL;
using EstateAgents.WebPortal.Models.Services;
using System;
using System.Web.Mvc;

namespace EstateAgents.WebPortal.Controllers
{
    [RoutePrefix("Services")]
    public class ServicesController : Controller
    {
        public ActionResult PropertyValuation()
        {
            PropertyValuationViewModel model = new PropertyValuationViewModel();
            return View(model);
        }

        public ActionResult PropertyRemovals()
        {
            PropertyRemovalsViewModel model = new PropertyRemovalsViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult PropertyValuationRequest(PropertyValuationViewModel model)
        {
            if (ModelState.IsValid)
            {
                PropertyValuations p = new PropertyValuations();
                p.ClientId = model.ClientId;
                p.Message = model.FurtherDetails;
                p.PropertyAddressLine1 = model.AddressLine1;
                p.PropertyAddressLine2 = model.AddressLine2;
                p.PropertyAddressLine3 = model.AddressLine3;
                p.PropertyAddressLine4 = model.AddressLine4;
                p.PropertyAddressPostcode = model.Postcode;

                EstateAgentsRepository.CreatePropertyValuation(p);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("PropertyValuation", model);
            }
        }

        [HttpPost]
        public ActionResult PropertyRemovalsRequest(PropertyRemovalsViewModel model)
        {
            if (ModelState.IsValid)
            {
                PropertyRemovals p = new PropertyRemovals();
                p.ClientId = model.ClientId;
                p.Message = model.FurtherDetails;
                p.PropertyAddressLine1 = model.AddressLine1;
                p.PropertyAddressLine2 = model.AddressLine2;
                p.PropertyAddressLine3 = model.AddressLine3;
                p.PropertyAddressLine4 = model.AddressLine4;
                p.PropertyAddressPostcode = model.Postcode;

                EstateAgentsRepository.CreatePropertyRemovals(p);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("PropertyRemovals", model);
            }
        }

    }
}