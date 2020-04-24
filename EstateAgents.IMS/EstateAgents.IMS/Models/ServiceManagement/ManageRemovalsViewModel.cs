using EstateAgents.Library.DAL;
using System.Collections.Generic;

namespace EstateAgents.IMS.Models.ServiceManagement
{
    public class ManageRemovalsViewModel
    {
        public List<PropertyRemovals> PropertyRemovals { get; set; }
        public ManageRemovalsViewModel()
        {
            this.PropertyRemovals = EstateAgentsRepository.GetPropertyRemovalsUnprocessed();
        }
    }
}