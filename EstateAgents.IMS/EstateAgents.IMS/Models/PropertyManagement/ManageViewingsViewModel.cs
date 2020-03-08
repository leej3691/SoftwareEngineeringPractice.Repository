using EstateAgents.Library.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstateAgents.IMS.Models.PropertyManagement
{
    public class ManageViewingsViewModel
    {
        public List<PropertyViewings> UnprocessedViewings { get; set; }
        public List<PropertyViewings> ScheduledViewings { get; set; }

        public ManageViewingsViewModel()
        {
            this.UnprocessedViewings = EstateAgentsRepository.GetUnprocessedPropertyViewings();
            this.ScheduledViewings = EstateAgentsRepository.GetScheduledPropertyViewings();
        }
    }
}