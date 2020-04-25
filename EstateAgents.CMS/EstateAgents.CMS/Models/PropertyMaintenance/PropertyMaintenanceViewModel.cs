using EstateAgents.Library.DAL;
using System.Collections.Generic;

namespace EstateAgents.CMS.Models.PropertyMaintenance
{
    public class PropertyMaintenanceViewModel
    {
        public List<Property> Properties { get; set; }
        public PropertyMaintenanceViewModel()
        {
            this.Properties = EstateAgentsRepository.GetAllProperties();
        }
    }
}