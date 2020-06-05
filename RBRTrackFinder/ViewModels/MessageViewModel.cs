﻿using Caliburn.Micro;
using RBRDesktopUI.Library.Api;
using RBRDesktopUI.Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRTrackFinder.ViewModels
{
    public class MessageViewModel : Screen
    {
        IMessageEndpoint _messageEndpoint;
        ILoggedInUserModel _loggedInUser;
        IMessagePostEndpoint _messagePostEndpoint;

        private MessageModel _messageData;
        private MessageDBModel _selectedMessage;
        private BindingList<MessageDBModel> _messages;

        private string _userId;
        private string _replyText;
        private string _messageId;
        private string _messageAttachment;
        private bool _canReply;

        private BindingList<MessageItemModel> _messageItem = new BindingList<MessageItemModel>();

        public MessageViewModel(IMessageEndpoint messageEndpoint, ILoggedInUserModel loggedInUser, IMessagePostEndpoint messagePost)
        {
            _messageEndpoint = messageEndpoint;
            _loggedInUser = loggedInUser;
            _messagePostEndpoint = messagePost;
        }

        protected override async void OnViewLoaded(object view) //Can be added a waiting cursor or icon when loading
        {
            base.OnViewLoaded(view);
            await LoadMessages();
        }

        public BindingList<MessageDBModel> Messages
        {
            get 
            {
                return _messages; 
            }
            set
            {
                _messages = value;
                NotifyOfPropertyChange(() => Messages);
            }
        }

        public MessageModel MessageData
        {
            get 
            { 
                return _messageData; 
            }
            set { _messageData = value; }
        }

        public BindingList<MessageItemModel> MessageItem
        {
            get { return _messageItem; }
            set 
            { 
                _messageItem = value;
                NotifyOfPropertyChange(() => MessageItem);
            }
        }

        private async Task LoadMessages()
        {
            var messageList = await _messageEndpoint.GetAll();
            Messages = new BindingList<MessageDBModel>(messageList);
        }

        public MessageDBModel SelectedMessage
        {
            get { return _selectedMessage; }
            set 
            { 
                _selectedMessage = value;
                NotifyOfPropertyChange(() => SelectedMessage);
            }
        }

        public string ReplyText
        {
            get 
            { 
                if (_replyText == null)
                {
                    _replyText = "Reply to a message...";
                }
                return _replyText; 
            }
            set 
            { 
                _replyText = value;
                NotifyOfPropertyChange(() => ReplyText);
                NotifyOfPropertyChange(() => CanReply);
            }
        }

        public async Task Reply()
        {
            await PostMessage();
        }

        public async Task PostMessage()
        {
            MessagePostModel messagePost = new MessagePostModel();

            messagePost.MessagePostDetails.Add(new MessagePostDetailModel
            {
                MessageContent = ReplyText,
                MessageSubject = SelectedMessage.MessageSubject,
                MessageDate = DateTime.UtcNow,
                MessageSenderId = _loggedInUser.Id,
                MessageAttachment = MessageAttachment,
                MessageAdresseeId = SelectedMessage.MessageSenderId,
                MessageId = MessageId
            });

            await _messagePostEndpoint.PostMessage(messagePost);
        }

        public string MessageId
        {
            get 
            {
                _messageId = (DateTime.UtcNow.ToString() + _loggedInUser.Id).Replace(" ", "");
                return _messageId; 
            }
            set { _messageId = value; }
        }

        public string MessageAttachment
        {
            get 
            { 
                return _messageAttachment; 
            }
            set 
            { 
                _messageAttachment = value; 
            }
        }

        public string UserId
        {
            get
            {
                _userId = _loggedInUser.Id;
                return _userId;
            }
            set
            {
                _userId = value;
            }
        }

        public bool CanReply
        {
            get 
            {
                bool output = false;

                if (_replyText != null || _replyText != "Reply to a message...")
                {
                    output = true;
                }
                return output; 
            }
            set 
            { 
                _canReply = value;
                NotifyOfPropertyChange(() => CanReply);
            }
        }

    }
}
