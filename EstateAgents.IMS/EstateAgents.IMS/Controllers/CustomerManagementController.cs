using EstateAgents.IMS.Models.CustomerManagement;
using EstateAgents.Library.DAL;
using System;
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

        [Route("MessageCustomer/{ClientId}/{MessageId}")]
        public ActionResult MessageCustomer(int ClientId, int MessageId)
        {
            MessageCustomerViewModel model = new MessageCustomerViewModel(ClientId, MessageId);
            return View(model);
        }
        
        public ActionResult ManageEnquiries()
        {
            ManageEnquiriesViewModel model = new ManageEnquiriesViewModel();
            return View(model);
        }

        [Route("ProcessChatbotEnquiry/{Id}")]
        public ActionResult ProcessChatbotEnquiry(int Id)
        {
            ChatbotTemplates t = EstateAgentsRepository.GetChatbotTemplateByTemplateId(Id);
            t.StaffProcessed = DateTime.Now;
            EstateAgentsRepository.UpdateChatbotTemplate(t);

            ManageEnquiriesViewModel model = new ManageEnquiriesViewModel();
            return View("ManageEnquiries", model);
        }

        [Route("ProcessEnquiry/{Id}")]
        public ActionResult ProcessEnquiry(int Id)
        {
            Enquiry e = EstateAgentsRepository.GetEnquiryByEnquiryId(Id);
            e.StaffMemberProcessed = DateTime.Now;
            EstateAgentsRepository.UpdateEnquiry(e);

            ManageEnquiriesViewModel model = new ManageEnquiriesViewModel();
            return View("ManageEnquiries", model);
        }


        [HttpPost]
        public ActionResult SendMessageReply(MessageCustomerViewModel model)
        {
            if (ModelState.IsValid)
            {
                //Create new staff reply
                Messages m = new Messages();
                m.ClientId = model.ClientId;
                m.MessageBody = model.MessageBody;
                m.MessageDate = DateTime.Today;
                m.MessageTime = DateTime.Now.ToShortTimeString();
                m.StaffResponse = true;

                EstateAgentsRepository.CreateMessages(m);

                //Mark client message as processed
                Messages cm = EstateAgentsRepository.GetMessageByMessageId(model.MessageId);
                cm.StaffProcessed = DateTime.Now;
                EstateAgentsRepository.UpdateMessages(cm);

                return RedirectToAction("CustomerMessages/" + model.ClientId, "CustomerManagement");
            }
            else
            {
                return View("Contact", model);
            }
        }

        public ActionResult ManageMessages()
        {
            ManageMessagesViewModel model = new ManageMessagesViewModel();
            return View(model);
        }
    }
}