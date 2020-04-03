using Caliburn.Micro;
using RBRTrackFinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace RBRTrackFinder.ViewModels
{
	public class ShellViewModel : DependencyObject
	{
		private string _firstName;
		private string _lastName;

		//Tutaj nie wiadomo czy nie usunąć! <== Dodana klasa TestCommand!

		public ICommand CloseWindowCommand { get; set; }

		public ShellViewModel()
		{
			this.CloseWindowCommand = new TestCommand(ExecuteCloseWindowCommand, CanExecuteCloseWindowCommand);
		}

		public bool CanExecuteCloseWindowCommand(object parameter)
		{
			return true;
		}

		public void ExecuteCloseWindowCommand(object parameter)
		{
			MessageBox.Show("Executing command 1");
		}

		// Tego nie usuwać

		public string UserNameTitleBar
		{
			get { return $"{FirstName} {LastName}"; }
		}

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

		public WindowState WindowState { get; private set; }

		public void LoadUserPage()
		{
			//ActivateItem(new UserViewModel());
		}

		public void LoadMessagePage()
		{
			//ActivateItem(new MessageViewModel());
		}

		public void ButtonOpenMenu()
		{
			//ButtonCloseMenu.Visibility = Visibility.Visible;
			//ButtonOpenMenu.Visibility = Visibility.Collapsed;
		}

		public void ButtonCloseMenu()
		{
			//ButtonCloseMenu.Visibility = Visibility.Collapsed;
			//ButtonOpenMenu.Visibility = Visibility.Visible;
		}

		public void MinimizeButton()
		{
			if (this.WindowState == WindowState.Normal)
			{
				this.WindowState = WindowState.Minimized;
			}
			else if (this.WindowState == WindowState.Minimized)
			{
				this.WindowState = WindowState.Normal;
			}
		}

		//public void ExitButton()
		//{
		//	System.Windows.Application.Current.Shutdown();
		//}

		private void Grid_MouseDown()
		{
			//this.DragMove();
		}
	}
}
