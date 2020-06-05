using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRDesktopUI.Library.Models
{
    public class MessagePostDetailModel
    {
        public string MessageId { get; set; }
        public string MessageSubject { get; set; }
        public string MessageContent { get; set; }
        public string MessageAttachment { get; set; }
        public string MessageAdresseeId { get; set; }
        public string MessageSenderId { get; set; }
        public DateTime MessageDate { get; set; }
        public string UserId { get; set; }
    }
}
