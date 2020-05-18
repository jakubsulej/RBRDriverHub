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
    public class TrackViewModel : Screen
    {
        private BindingList<TrackModel> _tracks;
        private TrackModel _selectedTrack;
        ITrackEndpoint _trackEndpoint;

        public TrackViewModel(ITrackEndpoint trackEndpoint)
        {
            _trackEndpoint = trackEndpoint;
        }

        protected override async void OnViewLoaded(object view) //Can be added a waiting cursor or icon when loading
        {
            base.OnViewLoaded(view);
            await LoadTracks();
        }

        public BindingList<TrackModel> Tracks
        {
            get { return _tracks; }
            set 
            {
                _tracks = value;
                NotifyOfPropertyChange(() => Tracks);
            }
        }

        private async Task LoadTracks()
        {
            var trackList = await _trackEndpoint.GetAll();
            Tracks = new BindingList<TrackModel>(trackList);
        }

        public TrackModel SelectedTrack
        {
            get { return _selectedTrack; }
            set
            {
                _selectedTrack = value;
                NotifyOfPropertyChange(() => SelectedTrack);
            }
        }
    }
}
