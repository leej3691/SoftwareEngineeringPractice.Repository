using EstateAgents.Library.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstateAgents.IMS.Models.CustomerManagement
{
    public class CustomerDetailsViewModel
    {
        public Client Client { get; set; }
        public CustomerDetailsViewModel(int Id)
        {
            this.Client = EstateAgentsRepository.GetClientByClientId(Id);
        }
    }
}