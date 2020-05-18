using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRDataManager.Library.Models
{
    public class MessageModel
    {
        public int Id { get; set; }
        public string MessageTopic { get; set; }
        public string MessageContent { get; set; }
        public string MessageAttachment { get; set; }
        public string MessageAdressee { get; set; }
        public string MessageSender { get; set; }
        public DateTime MessageDate { get; set; }

    }
}
