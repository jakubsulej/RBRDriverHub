using Caliburn.Micro;
using RBRTrackFinder.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using RBRDesktopUI.Library.Api;
using RBRTrackFinder.EventModels;

namespace RBRTrackFinder.ViewModels
{
    public class LoginViewModel : Screen
    {
		private string _userEmail = "sulejmedia@gmail.com";
		private string _password = "Password12345.";
		private IAPIHelper _apiHelper;
		private IUserRallyInfoEndpoint _userRallyInfo;
		private IEventAggregator _events;

		public LoginViewModel(IAPIHelper apiHelper, IEventAggregator events, IUserRallyInfoEndpoint userRallyInfo)
		{
			_apiHelper = apiHelper;
			_events = events;
			_userRallyInfo = userRallyInfo;
		}


		public string UserEmail
		{
			get { return _userEmail; }
			set 
			{
				_userEmail = value;
				NotifyOfPropertyChange(() => UserEmail);
				NotifyOfPropertyChange(() => CanLogIn);
			}
		}

		public string Password
		{
			get { return _password; }
			set 
			{ 
				_password = value;
				NotifyOfPropertyChange(() => Password);
				NotifyOfPropertyChange(() => CanLogIn);
			}
		}

		public bool IsErrorVisible
		{
			get 
			{
				bool output = false;

				if (String.IsNullOrWhiteSpace(ErrorMessage))
				{
					output = false;
				}
				else
				{
					output = true;
				}
				return output;
			}
		}

		private string _errorMessage;

		public string ErrorMessage
		{
			get { return _errorMessage; }
			set 
			{
				_errorMessage = value;
				NotifyOfPropertyChange(() => ErrorMessage);
				NotifyOfPropertyChange(() => IsErrorVisible);
			}
		}

		public bool CanLogIn
		{
			get
			{
				bool output = false;

				if (UserEmail?.Length > 0 && Password?.Length > 0)
				{
					output = true;
				}
				return output;
			}
		}

		public async Task LogIn()
		{
			try
			{
				ErrorMessage = "";
				var result = await _apiHelper.Authenticate(UserEmail, Password);

				// Capture more informations about the user
				await _apiHelper.GetLoggedInUserInfo(result.Access_Token);
				await _userRallyInfo.GetLoggedInUserRallyInfo();

				_events.PublishOnUIThread(new LogOnEvent());
			}
			catch (Exception ex)
			{
				ErrorMessage = ex.Message;
			}
		}
	}
}
