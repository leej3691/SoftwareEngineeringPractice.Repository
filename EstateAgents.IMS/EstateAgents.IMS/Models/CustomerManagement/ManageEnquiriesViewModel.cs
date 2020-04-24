using EstateAgents.Library.DAL;
using System.Collections.Generic;

namespace EstateAgents.IMS.Models.CustomerManagement
{
    public class ManageEnquiriesViewModel
    {
        public List<Enquiry> Enquiries { get; set; }
        public List<ChatbotTemplates> ChatbotTemplates { get; set; }
        public ManageEnquiriesViewModel()
        {
            this.ChatbotTemplates = EstateAgentsRepository.GetChatbotTemplatesCompletedUnprocessed();
            this.Enquiries = EstateAgentsRepository.GetEnquiriesUnprocessed();
        }
    }
}