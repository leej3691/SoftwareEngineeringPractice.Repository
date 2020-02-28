using EstateAgents.Library.DAL;
using Microsoft.AspNet.Identity;
using System;
using System.Web;

namespace EstateAgents.WebPortal.Models.Properties
{
    public class PropertyMakeOfferViewModel
    {
        public Property PropertyDetails { get; set; }
        public PropertyOffers PropertyOffer { get; set; }
        public int ClientId { get; set; }

        public PropertyMakeOfferViewModel()
        {
            this.PropertyDetails = new Property(); ;
            this.PropertyOffer = new PropertyOffers();
            this.ClientId = EstateAgentsRepository.GetClientByUserId(Guid.Parse(HttpContext.Current.User.Identity.GetUserId())).Id;
        }

        public PropertyMakeOfferViewModel(int Id)
        {
            this.PropertyDetails = EstateAgentsRepository.GetPropertyByPropertyId(Id);
            this.PropertyOffer = new PropertyOffers();
            this.ClientId = EstateAgentsRepository.GetClientByUserId(Guid.Parse(HttpContext.Current.User.Identity.GetUserId())).Id;
        }
    
    }
}