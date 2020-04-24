using EstateAgents.Library.DAL;
using Microsoft.AspNet.Identity;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace EstateAgents.WebPortal.Models.Messages
{
    public class MessagesReplyViewModel
    {
        /// <summary>
        /// The reply body
        /// </summary>
        [UIHint("TextArea")]
        [DisplayName("Reply")]
        [Required(ErrorMessage = "Please provide a reply body.")]
        public string Reply { get; set; }

        public int ClientId { get; set; }

        public MessagesReplyViewModel()
        {
            
        }

        public MessagesReplyViewModel(int ClientId)
        {
            this.ClientId = ClientId;
        }
     
    }
}