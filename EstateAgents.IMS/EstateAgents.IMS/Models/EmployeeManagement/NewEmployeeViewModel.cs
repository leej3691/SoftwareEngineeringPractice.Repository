using EstateAgents.Library.Attributes;
using EstateAgents.Library.Enums;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EstateAgents.IMS.Models.EmployeeManagement
{
    public class NewEmployeeViewModel
    {
        /// <summary>
        /// The title of the employee
        /// </summary>
        [UIHint("DropDown")]
        [DisplayName("Title")]
        [Required(ErrorMessage = "Please provide a employee.")]
        public PersonTitle? Title { get; set; }

        /// <summary>
        /// The forename of the employee
        /// </summary>
        [UIHint("TextBox")]
        [DisplayName("Forename")]
        [Required(ErrorMessage = "Please provide a forename.")]
        [MaxLength(50, ErrorMessage = "The forename must be less than 50 characters")]
        public string Forename { get; set; }

        /// <summary>
        /// The surname of the employee
        /// </summary>
        [UIHint("TextBox")]
        [DisplayName("Surname")]
        [Required(ErrorMessage = "Please provide a surname.")]
        [MaxLength(50, ErrorMessage = "The surname must be less than 50 characters")]
        public string Surname { get; set; }

        /// <summary>
        /// The email address for the employee
        /// </summary>
        [UIHint("EmailInput")]
        [DisplayName("Email")]
        [Required(ErrorMessage = "Please provide an email.")]
        [ValidEmail(ErrorMessage = "Please provide a valid email address.")]
        public string Email { get; set; }

        /// <summary>
        /// The mobile telephone number for the employee
        /// </summary>
        [UIHint("MobileInput")]
        [DisplayName("Mobile")]
        [Required(ErrorMessage = "Please provide a mobile number.")]
        [ValidMobile(ErrorMessage = "Please enter a valid mobile number.")]
        public string Mobile { get; set; }

        /// <summary>
        /// Date of birth of the employee
        /// </summary>
        [UIHint("DateInput")]
        [DisplayName("DOB")]
        [Required(ErrorMessage = "Please provide your date of birth.")]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// First line of the address for the employee
        /// </summary>
        [UIHint("TextBox")]
        [DisplayName("Address 1")]
        [Required(ErrorMessage = "Please provide address line 1.")]
        [MaxLength(50, ErrorMessage = "The address line 1 must be less than 50 characters")]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Second line of the address for the employee
        /// </summary>
        [DisplayName("Address 2")]
        [UIHint("TextBox")]
        [Required(ErrorMessage = "Please provide address line 2.")]
        [MaxLength(50, ErrorMessage = "The address line 2 must be less than 50 characters")]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Third line of the address for the employee
        /// </summary>
        [DisplayName("Address 3")]
        [UIHint("TextBox")]
        [Required(ErrorMessage = "Please provide address line 3.")]
        [MaxLength(50, ErrorMessage = "The address line 3 must be less than 50 characters")]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Fourth line of the address for the employee
        /// </summary>
        [UIHint("TextBox")]
        [DisplayName("Address 4")]
        [Required(ErrorMessage = "Please provide address line 4.")]
        [MaxLength(50, ErrorMessage = "The address line 4 must be less than 50 characters")]
        public string AddressLine4 { get; set; }

        /// <summary>
        /// Fifth line of the address for the employee
        /// </summary>
        [UIHint("TextBox")]
        [DisplayName("Address 5")]
        [Required(ErrorMessage = "Please provide address line 5.")]
        [MaxLength(50, ErrorMessage = "The address line 5 must be less than 50 characters")]
        public string AddressLine5 { get; set; }

        /// <summary>
        /// Postcode of the address for the employee
        /// </summary>
        [UIHint("PostcodeInput")]
        [DisplayName("Postcode")]
        [ValidPostcode(ErrorMessage = "Please provide a valid postcode")]
        [Required(ErrorMessage = "Please provide your postcode.")]
        [MaxLength(8, ErrorMessage = "The postcode must be less than 8 characters")]
        public string Postcode { get; set; }

        /// <summary>
        /// Start of the employee
        /// </summary>
        [UIHint("DateInput")]
        [DisplayName("Started")]
        [Required(ErrorMessage = "Please provide date started.")]
        public DateTime DateOfStart { get; set; }

        /// <summary>
        /// Date left of the employee
        /// </summary>
        [UIHint("DateInput")]
        [DisplayName("Left")]
        public DateTime? DateLeft { get; set; }

    }
}