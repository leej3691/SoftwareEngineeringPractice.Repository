using EstateAgents.Library.DAL;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Web;

namespace EstateAgents.WebPortal.Models.Properties
{
    public class PropertyOffersViewModel
    {
        public List<PropertyOffers> PropertyOffers { get; set; }

        public PropertyOffersViewModel()
        {
            this.PropertyOffers = EstateAgentsRepository.GetPropertyOffersByClientId(EstateAgentsRepository.GetClientByUserId(Guid.Parse(HttpContext.Current.User.Identity.GetUserId())).Id);
        }
    }
}