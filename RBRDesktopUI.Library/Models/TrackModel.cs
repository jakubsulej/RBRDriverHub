using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRDesktopUI.Library.Models
{
    public class TrackModel
    {
        private bool _trackIsInstalled;
        private string _trackInstallState;
        private string _trackId;
        private string _trackLength;
        private string _trackImage;

        public int Id { get; set; }

        public string TrackId
        {
            get { return _trackId; }
            set { _trackId = value; }
        }

        public string TrackName { get; set; }

        public DateTime TrackDate { get; set; }

        public string TrackDescription { get; set; }

        public bool TrackIsInstalled
        {
            get 
            { 
                return _trackIsInstalled; 
            }
            set 
            { 
                _trackIsInstalled = value; 
            }
        }

        public string TrackCountry { get; set; }

        public string TrackLength
        {
            get { return _trackLength; }
            set { _trackLength = value; }
        }

        public string TournamentTrackName
        {
            get { return $"{TrackName} {TrackLength}"; }
        }

        public string TrackViewModel
        {
            get { return $"{TrackId} {TrackName} {TrackIsInstalled}"; }
        }

        public string TrackInstallState
        {
            get 
            {
                if(_trackIsInstalled == false)
                {
                    _trackInstallState = "Not installed";
                }
                else
                {
                    _trackInstallState = "Currently installed";
                }
                return _trackInstallState; 
            }
            set { _trackInstallState = value; }
        }

        private double _trackLengthDecimal;

        public double TrackLengthDecimal
        {
            get 
            {
                _trackLengthDecimal = Convert.ToDouble(TrackLength);
                return _trackLengthDecimal; 
            }
            set { _trackLengthDecimal = value; }
        }

        public string TrackImage
        {
            get 
            {
                if(_trackId == "585")
                {
                    _trackImage = "/Media/Images/hradek.jpg";
                }
                else if(_trackId == "995")
                {
                    _trackImage = "/Media/Images/kormoran.jpg";
                }
                else if (_trackId == "116")
                {
                    _trackImage = "/Media/Images/stryckovy.jpg";
                }
                else if (_trackId == "999")
                {
                    _trackImage = "/Media/Images/undva.jpg";
                }
                else if (_trackId == "78")
                {
                    _trackImage = "/Media/Images/cotedarbroz.jpg";
                }
                else if (_trackId == "55")
                {
                    _trackImage = "/Media/Images/harwood_forest.jpg";
                }
                else if (_trackId == "1555")
                {
                    _trackImage = "/Media/Images/hazlach.jpg";
                }
                return _trackImage; 
            }
            set { _trackImage = value; }
        }

    }
}
