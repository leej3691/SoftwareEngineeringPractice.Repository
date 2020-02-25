using EstateAgents.Library.DAL;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Web;

namespace EstateAgents.WebPortal.Models.Properties
{
    public class PropertyViewingsViewModel
    {
        public List<PropertyViewings> PropertyViewings { get; set; }

        public PropertyViewingsViewModel()
        {
            int ClientId = EstateAgentsRepository.GetClientByUserId(Guid.Parse(HttpContext.Current.User.Identity.GetUserId())).Id;
            this.PropertyViewings = EstateAgentsRepository.GetPropertyViewingsByClientId(ClientId);
        }
    }
}