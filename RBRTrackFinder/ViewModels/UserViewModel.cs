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
    public class UserViewModel : Screen
    {
        private ILoggedInUserModel _loggedInUserModel;
        private IUserRallyInfoEndpoint _userRallyInfoEndpoint;

        private string _userLastName;
        private string _userFirstName;

        public UserViewModel(ILoggedInUserModel loggedInUserModel, IUserRallyInfoEndpoint userRallyInfoEndpoint)
        {
            _loggedInUserModel = loggedInUserModel;
            _userRallyInfoEndpoint = userRallyInfoEndpoint;
        }

        protected override async void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
            await LoadUserRallyInfo();
        }

        private async Task LoadUserRallyInfo()
        {
            var userInfo = await _userRallyInfoEndpoint.GetAll();
            UserRallyInfo = new BindingList<UserRallyInfoModel>(userInfo);
        }

        private BindingList<UserRallyInfoModel> _userRallyInfo;

        public BindingList<UserRallyInfoModel> UserRallyInfo
        {
            get
            {
                return _userRallyInfo;
            }
            set { _userRallyInfo = value; }
        }

        private string _userLicence;

        public string UserLicence
        {
            get
            {
                return _userLicence;
            }
            set
            {
                _userLicence = value;
                NotifyOfPropertyChange(() => UserLicence);
            }
        }

        public string UserFirstName
        {
            get 
            {
                _userFirstName = _loggedInUserModel.FirstName;
                return _userFirstName; 
            }
            set { _userFirstName = value; }
        }

        public string UserLastName
        {
            get 
            {
                _userLastName = _loggedInUserModel.LastName;
                return _userLastName; 
            }
            set { _userLastName = value; }
        }

        private string _userEmail;

        public string UserEmail
        {
            get 
            {
                _userEmail = _loggedInUserModel.EmailAddress;
                return _userEmail; 
            }
            set { _userEmail = value; }
        }
    }
}
