using EstateAgents.Library.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstateAgents.IMS.Models.PropertyManagement
{
    public class ProcessPropertyViewingViewModel
    {
        public PropertyViewings PropertyViewing { get; set; }
        public Client Buyer { get; set; }
        public string VendorMobile { get; set; }
        public EstateAgents.Library.Enums.PropertyViewingStatus? PropertyViewingStatus { get; set; }

        public ProcessPropertyViewingViewModel(int Id)
        {
            this.PropertyViewing = EstateAgentsRepository.GetPropertyViewingById(Id);
            this.Buyer = EstateAgentsRepository.GetClientByClientId(this.PropertyViewing.ClientId);
            var Property = EstateAgentsRepository.GetPropertyByPropertyId(this.PropertyViewing.PropertyId);
            this.VendorMobile = EstateAgentsRepository.GetClientByClientId(Property.VendorClientId).Mobile;
        }
    }
}