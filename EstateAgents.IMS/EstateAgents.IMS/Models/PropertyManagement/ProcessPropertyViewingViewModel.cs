using EstateAgents.Library.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EstateAgents.IMS.Models.PropertyManagement
{
    public class ProcessPropertyViewingViewModel
    {
        [UIHint("TextBox")]
        [DisplayName("Forename")]
        public string Forename { get; set; }
        
        [UIHint("TextBox")]
        [DisplayName("Surname")]
        public string Surname { get; set; }
        
        [UIHint("DateInput")]
        [DisplayName("Viewing Date")]
        public DateTime ViewingDate { get; set; }

        [UIHint("TextBox")]
        [DisplayName("Viewing Time")]
        public string ViewingTime { get; set; }
        public string VendorMobile { get; set; }
        public EstateAgents.Library.Enums.PropertyViewingStatus? PropertyViewingStatus { get; set; }
        public int ViewingId { get; set; }

        public ProcessPropertyViewingViewModel()
        {

        }

        public ProcessPropertyViewingViewModel(int Id)
        {
            PropertyViewings PropertyViewing = EstateAgentsRepository.GetPropertyViewingById(Id);
            Client Buyer = EstateAgentsRepository.GetClientByClientId(PropertyViewing.ClientId);
            var Property = EstateAgentsRepository.GetPropertyByPropertyId(PropertyViewing.PropertyId);
            
            this.Forename = Buyer.Forename;
            this.Surname = Buyer.Surname;
            this.VendorMobile = EstateAgentsRepository.GetClientByClientId(Property.VendorClientId).Mobile;
            this.ViewingDate = PropertyViewing.ViewingDate;
            this.ViewingTime = PropertyViewing.ViewingTime;
            Enum.TryParse(PropertyViewing.PropertyViewingStatusId.ToString(), out EstateAgents.Library.Enums.PropertyViewingStatus Status);
            this.PropertyViewingStatus = Status;
            this.ViewingId = Id;
        }
    }
}