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
			NotifyOfPropertyChange(() => ConfirmPasswordErrorVisibility);
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
			get 
			{ 
				return _password; 
			}
			set 
			{
				_password = value;
				NotifyOfPropertyChange(() => ConfirmPasswordErrorVisibility);
			}
		}

		private string _passwordErrorVisibility;

		public string PasswordErrorVisibility
		{
			get 
			{ 

				return _passwordErrorVisibility; 
			}
			set { _passwordErrorVisibility = value; }
		}


		private string _confirmPassword;

		public string ConfirmPassword
		{
			get { return _confirmPassword; }
			set 
			{ 
				_confirmPassword = value;
				NotifyOfPropertyChange(() => ConfirmPasswordErrorVisibility);
			}
		}

		private string _confirmPasswordErrorVisibility;

		public string ConfirmPasswordErrorVisibility
		{
			get 
			{
				_confirmPasswordErrorVisibility = "Hidden";

				if (_password != _confirmPassword)
				{
					_confirmPasswordErrorVisibility = "Visible";
				}
				else
				{
					_confirmPasswordErrorVisibility = "Hidden";
				}
				return _confirmPasswordErrorVisibility; 
			}
			set 
			{ 
				_confirmPasswordErrorVisibility = value;
				NotifyOfPropertyChange(() => ConfirmPasswordErrorVisibility);
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
