using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRDesktopUI.Library.Models
{
    public class MessageModel
    {
        private string _messageTopic;
        private string _messageTopicShort;
        private string _messageSender;
        private string _messageAttachment;
        private string _messageAttachmentState;
        private DateTime _messageDate;

        public int Id { get; set; }

        public string MessageTopic
        {
            get { return _messageTopic; }
            set { _messageTopic = value; }
        }

        public string MessageContent { get; set; }

        public string MessageAttachment
        {
            get { return _messageAttachment; }
            set { _messageAttachment = value; }
        }

        public string MessageAdressee { get; set; }

        public string MessageSender
        {
            get { return _messageSender; }
            set { _messageSender = value; }
        }

        public DateTime MessageDate
        {
            get { return _messageDate; }
            set { _messageDate = value; }
        }

        public string MessageTopicShort
        {
            get
            {
                if (_messageTopic.Length > 27)
                {
                    _messageTopicShort = _messageTopic.Substring(0, 27) + "...";
                }
                else
                {
                    _messageTopicShort = _messageTopic;
                }
                return _messageTopicShort;
            }
            set { _messageTopicShort = value; }
        }

        private string _messageSenderShort;

        public string MessageSenderShort
        {
            get 
            {
                if(_messageSender.Length > 20)
                {
                    _messageSenderShort = _messageSender.Substring(0, 20) + "...";
                }
                else
                {
                    _messageSenderShort = _messageSender;
                }
                return _messageSenderShort; 
            }
            set { _messageSenderShort = value; }
        }

        public string MessageAttachmentState
        {

            get 
            {
                _messageAttachmentState = "Hidden";

                if (_messageAttachment != null)
                {
                    _messageAttachmentState = "Visisble";
                }
                return _messageAttachmentState; 
            }
            set { _messageAttachmentState = value; }
        }

        private string _messageDateShort;

        public string MessageDateShort
        {
            get 
            {
                _messageDateShort = _messageDate.ToShortDateString();
                return _messageDateShort; 
            }
            set { _messageDateShort = value; }
        }
    }
}
