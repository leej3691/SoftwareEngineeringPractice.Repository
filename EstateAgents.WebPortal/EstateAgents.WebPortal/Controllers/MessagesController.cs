using EstateAgents.Library.DAL;
using EstateAgents.WebPortal.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EstateAgents.WebPortal.Controllers
{
    [RoutePrefix("Messages")]
    public class MessagesController : Controller
    {
        public ActionResult Messages()
        {
            MessagesViewModel model = new MessagesViewModel();
            return View(model);
        }

        [Route("MessagesReply/{ClientId}")]
        public ActionResult MessagesReply(int ClientId)
        {
            MessagesReplyViewModel model = new MessagesReplyViewModel(ClientId);
            return View(model);
        }

        [HttpPost]
        public ActionResult SendMessageReply(MessagesReplyViewModel model)
        {
            if (ModelState.IsValid)
            {
                Messages m = new Messages();
                m.ClientId = model.ClientId;
                m.MessageBody = model.Reply;
                m.MessageDate = DateTime.Today;
                m.MessageTime = DateTime.Now.ToShortTimeString();
                m.StaffResponse = false;

                EstateAgentsRepository.CreateMessages(m);

                return RedirectToAction("Messages", "Messages");
            }
            else
            {
                return View("Contact", model);
            }
        }
    }
}