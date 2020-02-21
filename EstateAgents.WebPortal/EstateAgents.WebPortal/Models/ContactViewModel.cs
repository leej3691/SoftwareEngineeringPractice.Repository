using EstateAgents.Library.Attributes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EstateAgents.WebPortal.Models
{
    public class ContactViewModel
    {
        /// <summary>
        /// The forename of the client
        /// </summary>
        [UIHint("TextBox")]
        [DisplayName("Forename")]
        [Required(ErrorMessage = "Please provide a Forename:")]
        [MaxLength(50, ErrorMessage = "The forename must be less than 50 characters")]
        public string Forename { get; set; }

        /// <summary>
        /// The surname of the client
        /// </summary>
        [UIHint("TextBox")]
        [DisplayName("Surname")]
        [Required(ErrorMessage = "Please provide a Surname:")]
        [MaxLength(50, ErrorMessage = "The surname must be less than 50 characters")]
        public string Surname { get; set; }

        /// <summary>
        /// The email address for the client
        /// </summary>
        [UIHint("EmailInput")]
        [DisplayName("Email")]
        [Required(ErrorMessage = "Please provide an Email:")]
        [ValidEmail(ErrorMessage = "Please provide a valid email address.")]
        public string Email { get; set; }

        /// <summary>
        /// The mobile telephone number for the client
        /// </summary>
        [UIHint("MobileInput")]
        [DisplayName("Mobile")]
        [ValidMobile(ErrorMessage = "Please enter a valid mobile number.")]
        public string Mobile { get; set; }

        /// <summary>
        /// The enquiry body
        /// </summary>
        [UIHint("TextArea")]
        [DisplayName("Enqiury")]
        [Required(ErrorMessage = "Please provide an enquiry body:")]
        public string EnquiryBody { get; set; }

    }
}