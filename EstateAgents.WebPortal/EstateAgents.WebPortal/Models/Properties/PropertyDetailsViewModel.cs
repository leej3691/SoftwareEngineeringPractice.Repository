using EstateAgents.Library.DAL;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Web;

namespace EstateAgents.WebPortal.Models.Properties
{
    public class PropertyDetailsViewModel
    {
        public Property PropertyDetails { get; set; }

        public List<PropertyImages> PropertyImages { get; set; }
        public int PropertyImagesCount { get; set; }
        public string PropertyTypeDescription { get; set; }
        public bool PropertySaved { get; set; }
        public int ClientId { get; set; }

        public PropertyDetailsViewModel(int Id)
        {
            this.PropertyDetails = EstateAgentsRepository.GetPropertyByPropertyId(Id);
            this.PropertyTypeDescription = EstateAgentsRepository.GetPropertyTypeDescriptionByPropertyTypeId(this.PropertyDetails.PropertyTypeId);

            List<PropertyImages> iList  = EstateAgentsRepository.GetPropertyImagesByPropertyId(Id);
            this.PropertyImages = iList;
            this.PropertyImagesCount = iList.Count;

            if (HttpContext.Current.User.Identity.GetUserId() == null)
            {
                this.PropertySaved = false;
                this.ClientId = 0;
            }
            else
            {
                this.ClientId = EstateAgentsRepository.GetClientByUserId(Guid.Parse(HttpContext.Current.User.Identity.GetUserId())).Id;
                this.PropertySaved = EstateAgentsRepository.CheckIfPropertyIsSavedForClient(this.ClientId, Id);

            }

        }

    }
}