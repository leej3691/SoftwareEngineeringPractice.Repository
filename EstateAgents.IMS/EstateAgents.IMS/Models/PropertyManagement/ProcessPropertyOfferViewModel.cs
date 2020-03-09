using EstateAgents.Library.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EstateAgents.IMS.Models.PropertyManagement
{
    public class ProcessPropertyOfferViewModel
    {
        [UIHint("TextBox")]
        [DisplayName("Forename")]
        public string Forename { get; set; }
        
        [UIHint("TextBox")]
        [DisplayName("Surname")]
        public string Surname { get; set; }
        
        [UIHint("DateInput")]
        [DisplayName("Offer Date")]
        public DateTime OfferDate { get; set; }

        [UIHint("TextBox")]
        [DisplayName("Offer Amount")]
        public decimal OfferAmount { get; set; }
        public string VendorMobile { get; set; }
        public EstateAgents.Library.Enums.PropertyOfferStatus? PropertyOfferStatus { get; set; }
        public int OffersId { get; set; }

        public ProcessPropertyOfferViewModel()
        {

        }

        public ProcessPropertyOfferViewModel(int Id)
        {
            PropertyOffers Offer = EstateAgentsRepository.GetPropertyOffersById(Id);
            Client Buyer = EstateAgentsRepository.GetClientByClientId(Offer.ClientId);
            var Property = EstateAgentsRepository.GetPropertyByPropertyId(Offer.PropertyId);
            
            this.Forename = Buyer.Forename;
            this.Surname = Buyer.Surname;
            this.VendorMobile = EstateAgentsRepository.GetClientByClientId(Property.VendorClientId).Mobile;
            this.OfferDate = Offer.Created;
            this.OfferAmount = Offer.OfferAmount;
            Enum.TryParse(Offer.PropertyOfferStatusId.ToString(), out EstateAgents.Library.Enums.PropertyOfferStatus Status);
            this.PropertyOfferStatus = Status;
            this.OffersId = Id;
        }
    }
}