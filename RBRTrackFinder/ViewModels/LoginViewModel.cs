﻿using Caliburn.Micro;
using RBRTrackFinder.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRTrackFinder.ViewModels
{
    public class LoginViewModel : Screen
    {
		private string _userEmail;
		private string _password;
		private IAPIHelper _apiHelper;

		public LoginViewModel(IAPIHelper apiHelper)
		{
			_apiHelper = apiHelper;
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
				var result = await _apiHelper.Authenticate(UserEmail, Password);
			}
			catch (Exception ex)
			{
				Console.WriteLine();
			}
		}
	}
}
