using Caliburn.Micro;
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

	public class ShellViewModel : Conductor<object>
	{

		private string _firstName;
		private string _lastName;
		private LoginViewModel _loginVM;

		public ShellViewModel(LoginViewModel loginVM) //Automatycznie otwiara okno loginViewModel
		{
			_loginVM = loginVM;
			ActivateItem(_loginVM);
		}

		public void LoadUserPage()
		{
			ActivateItem(new UserViewModel());
		}

		public void LoadMessagePage()
		{
			ActivateItem(new MessageViewModel());
		}

		//Rest of action

		public string UserNameTitleBar
		{
			get { return $"{FirstName} {LastName}"; }
		} 
		
		//Returns string FirstName and LastName to Textbl

		public string FirstName
		{
			get { return _firstName; }
			set { _firstName = value; }
		}

		public string LastName
		{
			get { return _lastName; }
			set { _lastName = value; }
		}
	}
}
