using EstateAgents.Library.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;

namespace EstateAgents.WebPortal.Models.Home
{
    public class HomeViewModel
    {
        public string RegisterEmail { get; set; }
        public Client ClientDetails { get; set; }
        public List<Property> Properties { get; set; }


        public HomeViewModel()
        {
            this.Properties = EstateAgentsRepository.GetTop3Properties();

            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                Guid UserId = Guid.Parse(HttpContext.Current.User.Identity.GetUserId());
                this.ClientDetails = EstateAgentsRepository.GetClientByUserId(UserId);
            }
            else
            {
                this.ClientDetails = new Client();
            }
            
        }
    }
}