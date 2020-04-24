using EstateAgents.Library.DAL;
using System.Collections.Generic;

namespace EstateAgents.IMS.Models.ServiceManagement
{
    public class ManageValuationsViewModel
    {
        public List<PropertyValuations> PropertyValuations { get; set; }
        public ManageValuationsViewModel()
        {
            this.PropertyValuations = EstateAgentsRepository.GetPropertyValuationsUnprocessed();
        }
    }
}