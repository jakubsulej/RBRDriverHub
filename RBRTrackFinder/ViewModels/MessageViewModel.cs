using Caliburn.Micro;
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
        private BindingList<MessageModel> _messages;
        IMessageEndpoint _messageEndpoint;
        private MessageModel _selectedMessage;

        public MessageViewModel(IMessageEndpoint messageEndpoint)
        {
            _messageEndpoint = messageEndpoint;
        }

        protected override async void OnViewLoaded(object view) //Can be added a waiting cursor or icon when loading
        {
            base.OnViewLoaded(view);
            await LoadMessages();
        }

        public BindingList<MessageModel> Messages
        {
            get { return _messages; }
            set
            {
                _messages = value;
                NotifyOfPropertyChange(() => Messages);
            }
        }

        private async Task LoadMessages()
        {
            var messageList = await _messageEndpoint.GetAll();
            Messages = new BindingList<MessageModel>(messageList);
        }

        public MessageModel SelectedMessage
        {
            get { return _selectedMessage; }
            set 
            { 
                _selectedMessage = value;
                NotifyOfPropertyChange(() => SelectedMessage);
            }
        }

    }
}
