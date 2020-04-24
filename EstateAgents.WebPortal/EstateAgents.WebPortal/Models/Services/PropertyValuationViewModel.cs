using EstateAgents.Library.DAL;
using Microsoft.AspNet.Identity;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace EstateAgents.WebPortal.Models.Services
{
    public class PropertyValuationViewModel
    {
        [UIHint("TextBox")]
        [DisplayName("Address Line 1")]
        [Required(ErrorMessage = "Please provide your address line 1.")]
        [MaxLength(50, ErrorMessage = "The address line 1 must be less than 50 characters")]
        public string AddressLine1 { get; set; }

        [UIHint("TextBox")]
        [DisplayName("Address Line 2")]
        [Required(ErrorMessage = "Please provide your address line 2.")]
        [MaxLength(50, ErrorMessage = "The address line 2 must be less than 50 characters")]
        public string AddressLine2 { get; set; }

        [UIHint("TextBox")]
        [DisplayName("Address Line 3")]
        [Required(ErrorMessage = "Please provide your address line 3.")]
        [MaxLength(50, ErrorMessage = "The address line 3 must be less than 50 characters")]
        public string AddressLine3 { get; set; }

        [UIHint("TextBox")]
        [DisplayName("Address Line 4")]
        [Required(ErrorMessage = "Please provide your address line 4.")]
        [MaxLength(50, ErrorMessage = "The address line 4 must be less than 50 characters")]
        public string AddressLine4 { get; set; }

        [UIHint("TextBox")]
        [DisplayName("Postcode")]
        [Required(ErrorMessage = "Please provide your Postcode.")]
        [MaxLength(50, ErrorMessage = "The Postcode must be less than 50 characters")]
        public string Postcode { get; set; }

        [UIHint("TextBox")]
        [DisplayName("Further Details")]
        [Required(ErrorMessage = "Please provide your further details.")]
        [MaxLength(50, ErrorMessage = "The further details must be less than 50 characters")]
        public string FurtherDetails { get; set; }
        public int ClientId { get; set; }

        public PropertyValuationViewModel()
        {
            this.ClientId = EstateAgentsRepository.GetClientByUserId(Guid.Parse(HttpContext.Current.User.Identity.GetUserId())).Id;
        }
    }
}