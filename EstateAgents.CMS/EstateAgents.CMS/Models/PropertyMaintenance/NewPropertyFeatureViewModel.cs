using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EstateAgents.CMS.Models.PropertyMaintenance
{
    public class NewPropertyFeatureViewModel
    {
        /// <summary>
        /// First line of the address for the property
        /// </summary>
        [UIHint("TextBox")]
        [DisplayName("Description")]
        [Required(ErrorMessage = "Please provide description.")]
        [MaxLength(50, ErrorMessage = "The description must be less than 50 characters")]
        public string Description { get; set; }

        public int PropertyId { get; set; }

        public NewPropertyFeatureViewModel()
        {

        }

        public NewPropertyFeatureViewModel(int PropertyId)
        {
            this.PropertyId = PropertyId;
        }
    }
}