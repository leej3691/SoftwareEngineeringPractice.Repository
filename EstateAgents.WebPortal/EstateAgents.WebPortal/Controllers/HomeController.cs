using EstateAgents.Library.DAL;
using EstateAgents.WebPortal.Models;
using EstateAgents.WebPortal.Models.Home;
using System.Web.Mvc;

namespace EstateAgents.WebPortal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            return View(model);
        }

        public ActionResult Contact()
        {
            ContactViewModel model = new ContactViewModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult ContactEnquiry(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                Enquiry e = new Enquiry();
                e.Forename = model.Forename;
                e.Surname = model.Surname;
                e.Email = model.Email;
                e.Mobile = model.Mobile;
                e.EnquiryBody = model.EnquiryBody;

                //TODO: Create row for Enquiry
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Contact", model);
            }
        }

        public ActionResult Chatbot()
        {
            ChatbotViewModel model = new ChatbotViewModel();

            return View(model);
        }
    }
}