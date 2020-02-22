using EstateAgents.Library.DAL;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EstateAgents.WebPortal.Models.Properties
{
    public class PropertyBookViewingViewModel
    {
        /// <summary>
        /// Viewing Date
        /// </summary>
        [UIHint("DateInput")]
        [DisplayName("Viewing Date")]
        [Required(ErrorMessage = "Please provide a viewing date.")]
        public DateTime ViewingDate { get; set; }

        /// <summary>
        /// Viewing Time
        /// </summary>
        [UIHint("TextBox")]
        [DisplayName("Viewing Time")]
        [Required(ErrorMessage = "Please provide a viewing time.")]
        [MaxLength(5, ErrorMessage = "The surname must be less than 50 characters")]
        public string ViewingTime { get; set; }

        public Property PropertyDetails { get; set; }
        public int ClientId { get; set; }

        public PropertyBookViewingViewModel()
        {
            this.PropertyDetails = new Property();
            this.ClientId = EstateAgentsRepository.GetClientByUserId(Guid.Parse(HttpContext.Current.User.Identity.GetUserId())).Id;
        }
        public PropertyBookViewingViewModel(int Id)
        {
            this.PropertyDetails = EstateAgentsRepository.GetPropertyByPropertyId(Id);
            this.ClientId = EstateAgentsRepository.GetClientByUserId(Guid.Parse(HttpContext.Current.User.Identity.GetUserId())).Id;
        }
    }
}