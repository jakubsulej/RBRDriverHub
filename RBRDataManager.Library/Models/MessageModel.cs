using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRDataManager.Library.Models
{
    public class MessageModel
    {
        public string UserName { get; set; }
        public string MessageId { get; set; }
        public string MessageSubject { get; set; }
        public string MessageContent { get; set; }
        public string MessageAttachment { get; set; }
        public string MessageAdresseeName { get; set; }
        public string MessageSenderName { get; set; }
        public DateTime MessageDate { get; set; }
    }
}
