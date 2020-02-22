using EstateAgents.Library.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstateAgents.WebPortal.Models.Properties
{
    public class PropertyMakeOfferViewModel
    {
        public Property PropertyDetails { get; set; }

        public PropertyMakeOfferViewModel(int Id)
        {
            this.PropertyDetails = EstateAgentsRepository.GetPropertyByPropertyId(Id);
        }
    
    }
}