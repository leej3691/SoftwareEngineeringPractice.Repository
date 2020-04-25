using EstateAgents.Library.DAL;
using System.Collections.Generic;

namespace EstateAgents.CMS.Models.PropertyMaintenance
{
    public class PropertyFeaturesViewModel
    {
        public List<PropertyFeatures> PropertyFeatures { get; set; }
        public int PropertyId { get; set; }

        public PropertyFeaturesViewModel()
        {
            
        }

        public PropertyFeaturesViewModel(int PropertyId)
        {
            this.PropertyFeatures = EstateAgentsRepository.GetAllPropertyFeaturesByPropertyId(PropertyId);
            this.PropertyId = PropertyId;
        }
    }
}