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
    public class TournamentViewModel : Screen
    {
        private BindingList<CarModel> _cars;
        private BindingList<TrackModel> _tracks;
        ICarEndpoint _carEndpoint;
        ITrackEndpoint _trackEndpoint;

        public TournamentViewModel(ICarEndpoint carEndpoint, ITrackEndpoint trackEndpoint) //Just a constructor with a dependency injection implement
        {
            _carEndpoint = carEndpoint;
            _trackEndpoint = trackEndpoint;
        }

        protected override async void OnViewLoaded(object view) //Can be added a waiting cursor or icon when loading
        {
            base.OnViewLoaded(view);
            await LoadCars();
        }

        private async Task LoadCars() //Async method for geting a car model to a list.
        {
            var carList = await _carEndpoint.GetAll();
            Cars = new BindingList<CarModel>(carList);
        }

        private async Task LoadTracks()
        {
            var trackList = await _trackEndpoint.GetAll();
            Tracks = new BindingList<TrackModel>(trackList);
        }

        public BindingList<CarModel> Cars
        {
            get { return _cars; }
            set {
                _cars = value;
                NotifyOfPropertyChange(() => Cars); //If set, fire notify
            }
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
    }
}
