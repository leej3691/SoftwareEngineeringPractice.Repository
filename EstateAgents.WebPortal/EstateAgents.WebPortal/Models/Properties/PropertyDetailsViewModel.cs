using EstateAgents.Library.DAL;

namespace EstateAgents.WebPortal.Models.Properties
{
    public class PropertyDetailsViewModel
    {
        public Property PropertyDetails { get; set; }
        public string PropertyTypeDescription { get; set; }

        public PropertyDetailsViewModel(int Id)
        {
            this.PropertyDetails = EstateAgentsRepository.GetPropertyByPropertyId(Id);
            this.PropertyTypeDescription = EstateAgentsRepository.GetPropertyTypeDescriptionByPropertyTypeId(this.PropertyDetails.PropertyTypeId);
        }
    }
}