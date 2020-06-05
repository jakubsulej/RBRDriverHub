using Caliburn.Micro;
using RBRDesktopUI.Library.Api;
using RBRDesktopUI.Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace RBRTrackFinder.ViewModels
{
    public class TournamentViewModel : Screen
    {
        private BindingList<CarModel> _cars;
        private BindingList<TrackModel> _tracks;

        private BindingList<TrackTournamentItemModel> _trackTournamentItem = new BindingList<TrackTournamentItemModel>();
        private BindingList<CarTournamentItemModel> _carTournamentItemModel = new BindingList<CarTournamentItemModel>();

        private CarModel _selectedCar;
        private TrackModel _selectedTrack;
        private TrackTournamentItemModel _selectedTrackToRemove;
        private CarModel _selectedCarToRemove;        
        private DateTime _startDate = DateTime.Now;
        private string _tournamentName;
        private string _tournamentDescription;
        private string _tournamentId;
        private string _userId;
        ILoggedInUserModel _loggedInUserModel;
        ICarEndpoint _carEndpoint;
        ITrackEndpoint _trackEndpoint;
        ITournamentCarPostEndpoint _tournamentCarPostEndpoint;
        ITournamentTrackPostEndpoint _tournamentTrackPostEndpoint;
        ITournamentPostEndpoint _tournamentPostEndpoint;

        public TournamentViewModel(ICarEndpoint carEndpoint, ITrackEndpoint trackEndpoint, ITournamentCarPostEndpoint tournamentCarPostEndpoint,
            ITournamentTrackPostEndpoint tournamentTrackPostEndpoint, ITournamentPostEndpoint tournamentPostEndpoint,
            ILoggedInUserModel loggedInUserModel) //Just a constructor with a dependency injection implement
        {
            _carEndpoint = carEndpoint;
            _trackEndpoint = trackEndpoint;
            _tournamentCarPostEndpoint = tournamentCarPostEndpoint;
            _tournamentTrackPostEndpoint = tournamentTrackPostEndpoint;
            _tournamentPostEndpoint = tournamentPostEndpoint;
            _loggedInUserModel = loggedInUserModel;
        }

        protected override async void OnViewLoaded(object view) //Can be added a waiting cursor or icon when loading
        {
            base.OnViewLoaded(view);
            await LoadCars();
            await LoadTracks();
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
            set
            {
                _cars = value;
                NotifyOfPropertyChange(() => Cars); //If set, fire notify
                NotifyOfPropertyChange(() => CanCreateTournament); //Whenever quantity changes checkout a CanAddToTournament method
            }
        }

        public BindingList<TrackModel> Tracks
        {
            get { return _tracks; }
            set
            {
                _tracks = value;
                NotifyOfPropertyChange(() => Tracks);
                NotifyOfPropertyChange(() => CanCreateTournament);
            }
        }

        public BindingList<TrackTournamentItemModel> TrackTournamentItem
        {
            get { return _trackTournamentItem; }
            set
            {
                _trackTournamentItem = value;
                NotifyOfPropertyChange(() => TrackTournamentItem);
            }
        }

        public BindingList<CarTournamentItemModel> CarTournamentItem
        {
            get { return _carTournamentItemModel; }
            set 
            { 
                _carTournamentItemModel = value;
                NotifyOfPropertyChange(() => CarTournamentItem);
            }
        }

        public CarModel SelectedCar //Select Car from a listView form
        {
            get { return _selectedCar; }
            set
            {
                _selectedCar = value;
                NotifyOfPropertyChange(() => SelectedCar);
                NotifyOfPropertyChange(() => CanAddCar);
            }
        }

        public TrackModel SelectedTrack //Select Track from a listView form
        {
            get { return _selectedTrack; }
            set
            {
                _selectedTrack = value;
                NotifyOfPropertyChange(() => SelectedTrack);
                NotifyOfPropertyChange(() => CanAddTrack);
            }
        }

        public TrackTournamentItemModel SelectedTrackToRemove
        {
            get { return _selectedTrackToRemove; }
            set
            {
                _selectedTrackToRemove = value;
                NotifyOfPropertyChange(() => SelectedTrackToRemove);
                NotifyOfPropertyChange(() => CanRemoveTrack);
            }
        }

        public CarModel SelectedCarToRemove
        {
            get { return _selectedCarToRemove; }
            set 
            {
                _selectedCarToRemove = value;
                NotifyOfPropertyChange(() => SelectedCarToRemove);
                NotifyOfPropertyChange(() => CanRemoveCar);
            }
        }

        public string TournamentName
        {
            get 
            {
                if(_tournamentName == null)
                {
                    _tournamentName = "Enter Tournament name";
                }
                return _tournamentName; 
            }
            set 
            {
                _tournamentName = value;
                NotifyOfPropertyChange(() => TournamentName);
                NotifyOfPropertyChange(() => CanCreateTournament);
            }
        }

        public string TournamentDescription
        {
            get 
            { 
                if(_tournamentDescription == null)
                {
                    _tournamentDescription = "Enter Tournament Description";
                }
                return _tournamentDescription; 
            }
            set 
            { 
                _tournamentDescription = value;
                NotifyOfPropertyChange(() => TournamentDescription);
                NotifyOfPropertyChange(() => CanCreateTournament);
            }
        }


        public DateTime StartTournamentDate
        {
            get { return _startDate; }
            set 
            { 
                _startDate = value; 
                OnPropertyChanged("StartDate"); 
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(name));
        }

        private int _stageOrder = 0;

        public int StageOrder
        {
            get
            {
                _stageOrder++;
                return _stageOrder;
            }
            set
            {
                _stageOrder = value;
            }
        }

        public string TournamentId
        {
            get 
            {
                if(UserId != null)
                {
                    DateTime dateTime = DateTime.UtcNow;

                    _tournamentId = (DateTime.UtcNow.ToUniversalTime().ToString("u") + "-" +  UserId).Replace(" ", "-");
                }
                else
                {
                    throw new Exception("Could not find any UserId");
                }

                return _tournamentId; 
            }
            set { _tournamentId = value; }
        }

        public void AddTrack()
        {
            TrackTournamentItemModel item = new TrackTournamentItemModel
            {
                Track = SelectedTrack,
                StageOrderInTournament = StageOrder
            };
            TrackTournamentItem.Add(item);
            NotifyOfPropertyChange(() => SubTotalKm);
            NotifyOfPropertyChange(() => CanCreateTournament);
        }

        public void AddCar()
        {
            CarTournamentItemModel existingItem = CarTournamentItem.FirstOrDefault(x => x.Car == SelectedCar);

            if (existingItem == null)
            {
                CarTournamentItemModel item = new CarTournamentItemModel
                {
                    Car = SelectedCar,
                };

                CarTournamentItem.Add(item);

                Cars.Remove(SelectedCar);
            }

            NotifyOfPropertyChange(() => CarTournamentItem);
            NotifyOfPropertyChange(() => CanCreateTournament);
        }

        public void RemoveCar()
        {
            MessageBox.Show("Car has been removed.");
        }

        public void RemoveTrack()
        {

            //NotifyOfPropertyChange(() => SubTotalKm);
            MessageBox.Show("Track has been removed.");
        }

        public async Task CreateTournament()
        {
            await PostTrackModel();
            await PostCarModel();
            await PostTournamentModel();
        }

        public async Task PostTrackModel()
        {
            TournamentTrackPostModel tournamentTrackPost = new TournamentTrackPostModel();

            foreach (var item in TrackTournamentItem)
            {
                tournamentTrackPost.TournamentTrackPostDetails.Add(new TournamentTrackPostDetailModel
                {
                    TrackId = item.Track.TrackId,
                    StageOrderInTournament = item.StageOrderInTournament,
                    TournamentId = TournamentId,
                    TournamentStageId = item.StageOrderInTournament + "-" + TournamentId
                });
            }

            await _tournamentTrackPostEndpoint.PostTrackTournament(tournamentTrackPost);
        }

        public async Task PostCarModel()
        {
            TournamentCarPostModel tournamentCarPost = new TournamentCarPostModel();

            foreach (var item in CarTournamentItem)
            {
                tournamentCarPost.TournamentCarPostDetails.Add(new TournamentCarPostDetailModel
                {
                    CarId = item.Car.Id,
                    TournamentId = TournamentId
                });
            }

            await _tournamentCarPostEndpoint.PostCarTournament(tournamentCarPost);
        }

        public async Task PostTournamentModel()
        {
            TournamentPostModel tournamentPost = new TournamentPostModel();

                tournamentPost.TournamentPostDetails.Add(new TournamentPostDetailModel
                {
                    TournamentDescription = TournamentDescription,
                    TournamentName = TournamentName,
                    TournamentId = TournamentId,
                    TournamentDate = StartTournamentDate,
                    TournamentUserId = UserId
                });

            await _tournamentPostEndpoint.PostTournament(tournamentPost);
        }

        public string UserId
        {
            get 
            {
                _userId = _loggedInUserModel.Id;
                return _userId; 
            }
            set 
            { 
                _userId = value;
                NotifyOfPropertyChange(() => TournamentId);
            }
        }

        public double SubTotalKm
        {
            get
            {
                double subTotalKm = 0.0;

                foreach (var item in TrackTournamentItem)
                {
                    subTotalKm += item.Track.TrackLengthDecimal;
                }
                return subTotalKm;
            }
        }

        public bool CanAddCar
        {
            get
            {
                bool output = false;

                if(_selectedCar != null)
                {
                    output = true;
                }
                return output;
            }
        }

        public bool CanAddTrack
        {
            get
            {
                bool output = false;

                if(SelectedTrack != null)
                {
                    output = true;
                }
                return output;
            }
        }

        public bool CanRemoveCar
        {
            get
            {
                bool output = false;

                if(_selectedCarToRemove != null)
                {
                    output = true;
                }

                return output;
            }
        }

        public bool CanRemoveTrack
        {
            get
            {
                bool output = false;

                if(SelectedTrackToRemove != null)
                {
                    output = true;
                }

                return output;
            }
        }

        public bool CanCreateTournament
        {
            get
            {
                bool output = false;

                if (TournamentName != null && TournamentDescription != null && CarTournamentItem.Count > 0 
                    && TrackTournamentItem.Count > 0)
                {
                    output = true;
                }

                return output;
            }
        }
    }
}

