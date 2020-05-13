using Caliburn.Micro;
using RBRDesktopUI.Library.Api;
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
		private SimpleContainer _container;

		public ShellViewModel(IEventAggregator events, LoginViewModel loginVM, MasterViewModel masterVM, 
			TournamentViewModel tournamentVM, SimpleContainer container)
		{
			_events = events;
			_container = container;
			_masterVM = masterVM;
			_loginVM = loginVM;
			_tournamentVM = tournamentVM;

			_events.Subscribe(this);
			ActivateItem(_container.GetInstance<LoginViewModel>());
		}
		public void Handle(LogOnEvent message)
		{
			ActivateItem(_masterVM);
		}

		public void LoadUserPage()
		{
			ActivateItem(new UserViewModel());
		}

		public void LoadMessagePage()
		{
			ActivateItem(new MessageViewModel());
		}

		public void LoadDownloadPage()
		{
			ActivateItem(new TrackViewModel());
		}

		public void LoadTournamentPage()
		{
			ActivateItem(_tournamentVM);
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



		public string UserNameTitleBar
		{
			get { return $"{FirstName} {LastName}"; }
		}

		public string FirstName
		{
			get { return _firstName; }
			set 
			{ 
				_firstName = value;
				NotifyOfPropertyChange(() => FirstName);
			}
		}

		public string LastName
		{
			get { return _lastName; }
			set 
			{ 
				_lastName = value;
				NotifyOfPropertyChange(() => LastName);
			}
		}
	}
}
