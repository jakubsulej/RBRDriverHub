using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRTrackFinder.ViewModels
{
    public class RegisterViewModel : Screen
    {
		private bool _canRegister;

		public RegisterViewModel()
		{

		}

		public void Register()
		{
			NotifyOfPropertyChange(() => PasswordErrorVisibility);
		}

		private string _firstName;

		public string FirstName
		{
			get { return _firstName; }
			set { _firstName = value; }
		}

		private string _lastName;

		public string LastName
		{
			get { return _lastName; }
			set { _lastName = value; }
		}

		private string _emailAddress;

		public string EmailAddress
		{
			get { return _emailAddress; }
			set { _emailAddress = value; }
		}

		private string _password;

		public string Password
		{
			get { return _password; }
			set 
			{
				_password = value;
				NotifyOfPropertyChange(() => PasswordErrorVisibility);
			}
		}

		private string _confirmPassword;

		public string ConfirmPassword
		{
			get { return _confirmPassword; }
			set 
			{ 
				_confirmPassword = value;
				NotifyOfPropertyChange(() => PasswordErrorVisibility);
			}
		}

		private string _passwordErrorVisibility;

		public string PasswordErrorVisibility
		{
			get 
			{
				_passwordErrorVisibility = "Hidden";

				if (_password != _confirmPassword)
				{
					_passwordErrorVisibility = "Visible";
				}
				else
				{
					_passwordErrorVisibility = "Hidden";
				}
				return _passwordErrorVisibility; 
			}
			set 
			{ 
				_passwordErrorVisibility = value;
				NotifyOfPropertyChange(() => PasswordErrorVisibility);
			}
		}


		public bool CanRegister
		{
			get 
			{
				bool output = false;

				if (_password == _confirmPassword)
				{
					output = true;
				}

				return output; 
			}
			set { _canRegister = value; }
		}

	}
}
