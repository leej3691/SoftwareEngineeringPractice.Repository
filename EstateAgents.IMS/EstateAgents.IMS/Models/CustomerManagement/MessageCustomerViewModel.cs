using EstateAgents.Library.DAL;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EstateAgents.IMS.Models.CustomerManagement
{
    public class MessageCustomerViewModel
    {
        /// <summary>
        /// The reply body
        /// </summary>
        [UIHint("TextArea")]
        [DisplayName("Message")]
        [Required(ErrorMessage = "Please provide a message body.")]
        public string MessageBody { get; set; }

        public int MessageId { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }

        public MessageCustomerViewModel()
        {

        }

        public MessageCustomerViewModel(int ClientId, int MessageId)
        {
            this.ClientId = ClientId;
            this.Client = EstateAgentsRepository.GetClientByClientId(ClientId);
            this.MessageId = MessageId;
        }
    }
}