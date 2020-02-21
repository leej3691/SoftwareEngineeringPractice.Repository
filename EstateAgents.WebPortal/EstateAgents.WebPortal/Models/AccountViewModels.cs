using EstateAgents.Library.Attributes;
using EstateAgents.Library.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EstateAgents.WebPortal.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
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
        [DisplayName("Mobile Telephone")]
        [Required(ErrorMessage = "Please provide a mobile number.")]
        [ValidMobile(ErrorMessage = "Please enter a valid mobile number.")]
        public string Mobile { get; set; }

        /// <summary>
        /// Date of birth of the client
        /// </summary>
        [UIHint("DateInput")]
        [DisplayName("Date Of Birth")]
        [Required(ErrorMessage = "Please provide your date of birth.")]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// First line of the address for the client
        /// </summary>
        [UIHint("TextBox")]
        [DisplayName("Address Line 1")]
        [Required(ErrorMessage = "Please provide address line 1.")]
        [MaxLength(50, ErrorMessage = "The address line 1 must be less than 50 characters")]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Second line of the address for the client
        /// </summary>
        [DisplayName("Address Line 2")]
        [UIHint("TextBox")]
        [Required(ErrorMessage = "Please provide address line 2.")]
        [MaxLength(50, ErrorMessage = "The address line 2 must be less than 50 characters")]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Third line of the address for the client
        /// </summary>
        [DisplayName("Address Line 3")]
        [UIHint("TextBox")]
        [Required(ErrorMessage = "Please provide address line 3.")]
        [MaxLength(50, ErrorMessage = "The address line 3 must be less than 50 characters")]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Fourth line of the address for the client
        /// </summary>
        [UIHint("TextBox")]
        [DisplayName("Address Line 4")]
        [Required(ErrorMessage = "Please provide address line 4.")]
        [MaxLength(50, ErrorMessage = "The address line 4 must be less than 50 characters")]
        public string AddressLine4 { get; set; }

        /// <summary>
        /// Fifth line of the address for the client
        /// </summary>
        [UIHint("TextBox")]
        [DisplayName("Address Line 5")]
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


        /// <summary>
        /// The password to be set by the client
        /// </summary>
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please provide a password:")]
        public string Password { get; set; }

        /// <summary>
        /// The password to be confirmed by the client
        /// </summary>
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [Required(ErrorMessage = "Please confirm your password:")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
