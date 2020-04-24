using EstateAgents.Library.DAL;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstateAgents.WebPortal.Models.Messages
{
    public class MessagesViewModel
    {
        public List<EstateAgents.Library.DAL.Messages> Messages { get; set; }

        public MessagesViewModel()
        {
            int ClientId = EstateAgentsRepository.GetClientByUserId(Guid.Parse(HttpContext.Current.User.Identity.GetUserId())).Id;
            this.Messages = EstateAgentsRepository.GetMessagesByClientId(ClientId);
        }
    }
}