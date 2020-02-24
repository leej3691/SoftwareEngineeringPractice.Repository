using EstateAgents.Library.DAL;
using System.Collections.Generic;

namespace EstateAgents.WebPortal.Models.Properties
{
    public class PropertyShowRoomViewModel
    {
        public List<Property> PropertyList { get; set; }

        public PropertyShowRoomViewModel()
        {
            this.PropertyList = EstateAgentsRepository.GetAllProperties();
        }
    }
}