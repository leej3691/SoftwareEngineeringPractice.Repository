using EstateAgents.Library.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstateAgents.IMS.Models.CustomerManagement
{
    public class ManageMessagesViewModel
    {
        public List<Messages> Messages { get; set; }

        public ManageMessagesViewModel()
        {
            this.Messages = EstateAgentsRepository.GetUnprocessedMessages();
        }
    }
}