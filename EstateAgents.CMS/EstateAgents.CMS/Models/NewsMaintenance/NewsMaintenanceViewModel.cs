using EstateAgents.Library.DAL;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EstateAgents.CMS.Models.NewsMaintenance
{
    public class NewsMaintenanceViewModel
    {
        [UIHint("TextArea")]
        [DisplayName("News Description")]
        public string NewsDescription { get; set; }
        public List<News> News { get; set; }
        public NewsMaintenanceViewModel()
        {
            this.NewsDescription = "";
            this.News = EstateAgentsRepository.GetAllNews();
        }
    }
}