using EstateAgents.Library.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstateAgents.IMS.Models.CustomerManagement
{
    public class CustomerMessagesViewModel
    {
        public List<Messages> Messages { get; set; }
        public Client Client { get; set; }
        public CustomerMessagesViewModel(int Id)
        {
            this.Messages = EstateAgentsRepository.GetMessagesByClientId(Id);
            this.Client = EstateAgentsRepository.GetClientByClientId(Id);
        }
    }
}