using Caliburn.Micro;
using RBRDesktopUI.Library.Api;
using RBRDesktopUI.Library.Models;
using RBRTrackFinder.EventModels;
using RBRTrackFinder.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace RBRTrackFinder.ViewModels
{

	public class ShellViewModel : Conductor<object>, IHandle<LogOnEvent>
	{

		private string _firstName;
		private string _lastName;

		private IEventAggregator _events;
		private MasterViewModel _masterVM;
		private LoginViewModel _loginVM;
		private TournamentViewModel _tournamentVM;
		private TrackViewModel _trackVM;
		private MessageViewModel _messageVM;
		private SimpleContainer _container;
		private UserViewModel _userVM;
		private ILoggedInUserModel _loggedInUserModel;
		private IAPIHelper _apiHelper;

		public ShellViewModel(IEventAggregator events, LoginViewModel loginVM, MasterViewModel masterVM, 
			TournamentViewModel tournamentVM, UserViewModel userVM, TrackViewModel trackVM, MessageViewModel messageVM, SimpleContainer container,
			ILoggedInUserModel loggedInUserModel, IAPIHelper apiHelper)
		{
			_events = events;
			_container = container;
			_masterVM = masterVM;
			_loginVM = loginVM;
			_tournamentVM = tournamentVM;
			_trackVM = trackVM;
			_messageVM = messageVM;
			_userVM = userVM;
			_loggedInUserModel = loggedInUserModel;
			_apiHelper = apiHelper;

			_events.Subscribe(this);
			ActivateItem(_container.GetInstance<LoginViewModel>());
		}
		public void Handle(LogOnEvent message)
		{
			ActivateItem(_masterVM);
			_loginVM = _container.GetInstance<LoginViewModel>();
		}

		public void LoadUserPage()
		{
			ActivateItem(_userVM);
		}

		public void LoadMessagePage()
		{
			ActivateItem(_messageVM);
		}

		public void LoadDownloadPage()
		{
			ActivateItem(_trackVM);
			_trackVM = _container.GetInstance<TrackViewModel>();
		}

		public void LoadTournamentPage()
		{
			ActivateItem(_tournamentVM);
			_tournamentVM = _container.GetInstance<TournamentViewModel>();
		}

		public void LoadForumPage()
		{
			
		}

		public void LoadLoginPage()
		{
			if (_loginVM.IsActive)
			{
				MessageBox.Show("Is currently active!");
			}
			else
			{
				ActivateItem(_loginVM);
			}
		}

		public string FirstName
		{
			get 
			{
				_firstName = _loggedInUserModel.FirstName;
				return _firstName; 
			}
			set 
			{
				_firstName = value;
				NotifyOfPropertyChange(() => FirstName);
			}
		}

		public string LastName
		{
			get 
			{
				_lastName = _loggedInUserModel.LastName;
				return _lastName;
			}
			set 
			{ 
				_lastName = value;
				NotifyOfPropertyChange(() => LastName);
			}
		}
	}
}
