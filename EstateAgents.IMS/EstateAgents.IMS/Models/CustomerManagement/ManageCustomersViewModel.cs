using EstateAgents.Library.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstateAgents.IMS.Models.CustomerManagement
{
    public class ManageCustomersViewModel
    {
        public List<Client> Buyers { get; set; }
        public List<Client> Vendors { get; set; }

        public ManageCustomersViewModel()
        {
            this.Buyers = EstateAgentsRepository.GetAllBuyers();
            this.Vendors = EstateAgentsRepository.GetAllVendors();
        }
    }
}