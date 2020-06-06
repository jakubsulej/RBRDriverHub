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
        private IUserRallyInfoModel _userRallyInfoModel;
        private IUserRallyInfoEndpoint _userRallyInfoEndpoint;

        private string _userLastName;
        private string _userFirstName;
        private string _userLicence;
        private string _totalNumberOfKm;
        private int _enteredTournaments;
        private int _wonTournaments;
        private int _finnishedTournaments;

        public UserViewModel(ILoggedInUserModel loggedInUserModel, IUserRallyInfoModel userRallyInfoModel, IUserRallyInfoEndpoint userRallyInfoEndpoint)
        {
            _loggedInUserModel = loggedInUserModel;
            _userRallyInfoEndpoint = userRallyInfoEndpoint;
            _userRallyInfoModel = userRallyInfoModel;
        }

        public int FinnishedTournaments
        {
            get 
            {
                _finnishedTournaments = _userRallyInfoModel.FinnishedTournaments;
                return _finnishedTournaments; 
            }
            set { _finnishedTournaments = value; }
        }


        public int WonTournaments
        {
            get 
            {
                _wonTournaments = _userRallyInfoModel.WonTournaments;
                return _wonTournaments; 
            }
            set { _wonTournaments = value; }
        }


        public int EnteredTournaments
        {
            get 
            {
                _enteredTournaments = _userRallyInfoModel.EnteredTournaments;
                return _enteredTournaments; 
            }
            set { _enteredTournaments = value; }
        }


        public string TotalNumberOfKm
        {
            get 
            {
                _totalNumberOfKm = _userRallyInfoModel.TotalNumberOfKm.ToString() + " Km";
                return _totalNumberOfKm; 
            }
            set { _totalNumberOfKm = value; }
        }


        public string UserLicence
        {
            get
            {
                _userLicence = _userRallyInfoModel.UserLicence;
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
