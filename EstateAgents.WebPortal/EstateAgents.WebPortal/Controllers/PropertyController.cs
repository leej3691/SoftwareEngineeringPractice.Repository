using EstateAgents.Library.DAL;
using EstateAgents.WebPortal.Models.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EstateAgents.WebPortal.Controllers
{
    [RoutePrefix("Property")]
    public class PropertyController : Controller
    {
        // GET: Property
        public ActionResult PropertyShowroom()
        {
            return View();
        }

        public ActionResult PropertySearch()
        {
            return View();
        }

        public ActionResult PropertySaved()
        {
            return View();
        }

        public ActionResult PropertyMakeOffer()
        {
            return View();
        }

        public ActionResult PropertyDetails()
        {
            return View();
        }

        [Route("PropertyDetails/{id}")]
        public ActionResult PropertyDetails(int Id)
        {
            PropertyDetailsViewModel model = new PropertyDetailsViewModel(Id);

            return View(model);
        }

        public ActionResult PropertyBookViewing()
        {
            return View();
        }

    }
}