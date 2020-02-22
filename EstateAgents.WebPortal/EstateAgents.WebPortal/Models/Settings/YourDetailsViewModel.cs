using EstateAgents.Library.Attributes;
using EstateAgents.Library.DAL;
using EstateAgents.Library.Enums;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EstateAgents.WebPortal.Models.Settings
{
    public class YourDetailsViewModel
    {
        /// <summary>
        /// The title of the client
        /// </summary>
        [UIHint("DropDown")]
        [DisplayName("Title")]
        [Required(ErrorMessage = "Please provide a Title.")]
        public PersonTitle? Title { get; set; }

        /// <summary>
        /// The forename of the client
        /// </summary>
        [UIHint("TextBox")]
        [DisplayName("Forename")]
        [Required(ErrorMessage = "Please provide a forename.")]
        [MaxLength(50, ErrorMessage = "The forename must be less than 50 characters")]
        public string Forename { get; set; }

        /// <summary>
        /// The surname of the client
        /// </summary>
        [UIHint("TextBox")]
        [DisplayName("Surname")]
        [Required(ErrorMessage = "Please provide a surname.")]
        [MaxLength(50, ErrorMessage = "The surname must be less than 50 characters")]
        public string Surname { get; set; }

        /// <summary>
        /// The email address for the client
        /// </summary>
        [UIHint("EmailInput")]
        [DisplayName("Email")]
        [Required(ErrorMessage = "Please provide an email.")]
        [ValidEmail(ErrorMessage = "Please provide a valid email address.")]
        public string Email { get; set; }

        /// <summary>
        /// The mobile telephone number for the client
        /// </summary>
        [UIHint("MobileInput")]
        [DisplayName("Mobile")]
        [Required(ErrorMessage = "Please provide a mobile number.")]
        [ValidMobile(ErrorMessage = "Please enter a valid mobile number.")]
        public string Mobile { get; set; }

        /// <summary>
        /// Date of birth of the client
        /// </summary>
        [UIHint("DateInput")]
        [DisplayName("DOB")]
        [Required(ErrorMessage = "Please provide your date of birth.")]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// First line of the address for the client
        /// </summary>
        [UIHint("TextBox")]
        [DisplayName("Address1")]
        [Required(ErrorMessage = "Please provide address line 1.")]
        [MaxLength(50, ErrorMessage = "The address line 1 must be less than 50 characters")]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Second line of the address for the client
        /// </summary>
        [DisplayName("Address2")]
        [UIHint("TextBox")]
        [Required(ErrorMessage = "Please provide address line 2.")]
        [MaxLength(50, ErrorMessage = "The address line 2 must be less than 50 characters")]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Third line of the address for the client
        /// </summary>
        [DisplayName("Address3")]
        [UIHint("TextBox")]
        [Required(ErrorMessage = "Please provide address line 3.")]
        [MaxLength(50, ErrorMessage = "The address line 3 must be less than 50 characters")]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Fourth line of the address for the client
        /// </summary>
        [UIHint("TextBox")]
        [DisplayName("Address4")]
        [Required(ErrorMessage = "Please provide address line 4.")]
        [MaxLength(50, ErrorMessage = "The address line 4 must be less than 50 characters")]
        public string AddressLine4 { get; set; }

        /// <summary>
        /// Fifth line of the address for the client
        /// </summary>
        [UIHint("TextBox")]
        [DisplayName("Address5")]
        [Required(ErrorMessage = "Please provide address line 5.")]
        [MaxLength(50, ErrorMessage = "The address line 5 must be less than 50 characters")]
        public string AddressLine5 { get; set; }

        /// <summary>
        /// Postcode of the address for the client
        /// </summary>
        [UIHint("PostcodeInput")]
        [DisplayName("Postcode")]
        [ValidPostcode(ErrorMessage = "Please provide a valid postcode")]
        [Required(ErrorMessage = "Please provide your postcode.")]
        [MaxLength(8, ErrorMessage = "The postcode must be less than 8 characters")]
        public string Postcode { get; set; }
        public int ClientId { get; set; }

        public YourDetailsViewModel()
        {
            Client c = EstateAgentsRepository.GetClientByUserId(Guid.Parse(HttpContext.Current.User.Identity.GetUserId()));
            this.AddressLine1 = c.AddressLine1;
            this.AddressLine2 = c.AddressLine2;
            this.AddressLine3 = c.AddressLine3;
            this.AddressLine4 = c.AddressLine4;
            this.AddressLine5 = c.AddressLine5;
            this.DateOfBirth = c.DateOfBirth;
            this.Email = c.Email;
            this.Forename = c.Forename;
            this.Mobile = c.Mobile;
            this.Postcode = c.Postcode;
            this.Surname = c.Surname;
            Enum.TryParse(c.Title, out PersonTitle title);
            this.Title = title;
            this.ClientId = c.Id;
        }
    }
}