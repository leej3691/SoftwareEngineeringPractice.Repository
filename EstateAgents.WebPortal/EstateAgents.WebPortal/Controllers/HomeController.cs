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

            return View();
        }
    }
}