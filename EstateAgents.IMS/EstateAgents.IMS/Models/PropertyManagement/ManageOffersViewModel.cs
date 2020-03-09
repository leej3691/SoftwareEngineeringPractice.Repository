using EstateAgents.Library.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstateAgents.IMS.Models.PropertyManagement
{
    public class ManageOffersViewModel
    {
        public List<PropertyOffers> UnprocessedOffers { get; set; }
        public List<PropertyOffers> AcceptedOffers { get; set; }
        public List<PropertyOffers> OffersHistory { get; set; }

        public ManageOffersViewModel()
        {
            this.UnprocessedOffers = EstateAgentsRepository.GetUnprocessedPropertyOffers();
            this.AcceptedOffers = EstateAgentsRepository.GetAcceptedPropertyOffers();
            this.OffersHistory = EstateAgentsRepository.GetAllOffers();
        }
    }
}