using EstateAgents.Library.DAL;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Web;

namespace EstateAgents.WebPortal.Models.Properties
{
    public class PropertySavedViewModel
    {
        public List<Property> PropertyList { get; set; }
        public int ClientId { get; set; }

        public PropertySavedViewModel()
        {
            int ClientId = EstateAgentsRepository.GetClientByUserId(Guid.Parse(HttpContext.Current.User.Identity.GetUserId())).Id;
            this.PropertyList = EstateAgentsRepository.GetPropertyListSavedByClientId(ClientId);
            this.ClientId = ClientId;
        }

        public PropertySavedViewModel(List<Property> pList)
        {
            this.PropertyList = pList;
        }
    }
}