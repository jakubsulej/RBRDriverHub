using Caliburn.Micro;
using RBRTrackFinder.Models;
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
        private BindingList<string> _tracks;

        public BindingList<string> Tracks
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
