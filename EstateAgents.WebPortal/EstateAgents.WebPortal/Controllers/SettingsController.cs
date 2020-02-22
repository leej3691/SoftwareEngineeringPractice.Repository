using EstateAgents.Library.DAL;
using EstateAgents.Library.Enums;
using EstateAgents.WebPortal.Models.Settings;
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
            YourDetailsViewModel model = new YourDetailsViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult YourDetailsUpdate(YourDetailsViewModel model)
        {
            if (ModelState.IsValid)
            {
                Client c = EstateAgentsRepository.GetClientByClientId(model.ClientId);
                c.AddressLine1 = model.AddressLine1;
                c.AddressLine2 = model.AddressLine2;
                c.AddressLine3 = model.AddressLine3;
                c.AddressLine4 = model.AddressLine4;
                c.AddressLine5 = model.AddressLine5;
                c.DateOfBirth = model.DateOfBirth;
                c.Email = model.Email;
                c.Forename = model.Forename;
                c.Mobile = model.Mobile;
                c.Postcode = model.Postcode;
                c.Surname = model.Surname;
                c.Title = model.Title.ToString();
                EstateAgentsRepository.UpdateClient(c);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("YourDetails", model);
            }
        }

        public ActionResult FAQ()
        {
            return View();
        }
    }
}