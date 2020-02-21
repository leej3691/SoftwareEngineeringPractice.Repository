using EstateAgents.Library.DAL;
using System.Collections.Generic;

namespace EstateAgents.WebPortal.Models.Properties
{
    public class PropertyDetailsViewModel
    {
        public Property PropertyDetails { get; set; }

        public List<PropertyImages> PropertyImages { get; set; }
        public int PropertyImagesCount { get; set; }
        public string PropertyTypeDescription { get; set; }

        public PropertyDetailsViewModel(int Id)
        {
            this.PropertyDetails = EstateAgentsRepository.GetPropertyByPropertyId(Id);
            this.PropertyTypeDescription = EstateAgentsRepository.GetPropertyTypeDescriptionByPropertyTypeId(this.PropertyDetails.PropertyTypeId);

            List<PropertyImages> iList  = EstateAgentsRepository.GetPropertyImagesByPropertyId(Id);
            this.PropertyImages = iList;
            this.PropertyImagesCount = iList.Count;
        }
    }
}