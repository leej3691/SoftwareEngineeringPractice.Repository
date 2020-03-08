using EstateAgents.IMS.Models.CustomerManagement;
using System.Web.Mvc;

namespace EstateAgents.IMS.Controllers
{
    [RoutePrefix("CustomerManagement")]
    public class CustomerManagementController : Controller
    {
        public ActionResult ManageCustomers()
        {
            ManageCustomersViewModel model = new ManageCustomersViewModel();
            return View(model);
        }

        [Route("CustomerDetails/{Id}")]
        public ActionResult CustomerDetails(int Id)
        {
            CustomerDetailsViewModel model = new CustomerDetailsViewModel(Id);
            return View(model);
        }

        [Route("CustomerMessages/{Id}")]
        public ActionResult CustomerMessages(int Id)
        {
            CustomerMessagesViewModel model = new CustomerMessagesViewModel(Id);
            return View(model);
        }

        public ActionResult ManageMessages()
        {
            ManageMessagesViewModel model = new ManageMessagesViewModel();
            return View(model);
        }
    }
}