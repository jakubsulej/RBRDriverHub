using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRDesktopUI.Library.Models
{
    public class MessageModel
    {
        private string _messageSubject;
        private string _messageSubjectShort;
        private string _messageSender;
        private string _messageAttachment;
        private string _messageAttachmentState;
        private DateTime _messageDate;

        public string MessageId { get; set; }

        public string UserId { get; set; }

        public string MessageSubject
        {
            get { return _messageSubject; }
            set { _messageSubject = value; }
        }

        public string MessageContent { get; set; }

        public string MessageAttachment
        {
            get { return _messageAttachment; }
            set { _messageAttachment = value; }
        }

        public string MessageAdresseeId { get; set; }

        public string MessageSenderId
        {
            get { return _messageSender; }
            set { _messageSender = value; }
        }

        public DateTime MessageDate
        {
            get { return _messageDate; }
            set { _messageDate = value; }
        }

        public string MessageSubjectShort
        {
            get
            {
                if (_messageSubject.Length > 27)
                {
                    _messageSubjectShort = _messageSubject.Substring(0, 27) + "...";
                }
                else
                {
                    _messageSubjectShort = _messageSubject;
                }
                return _messageSubjectShort;
            }
            set { _messageSubjectShort = value; }
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
