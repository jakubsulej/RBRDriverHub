using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRTrackFinder.Models
{
    public class TrackModel
    {
        public string TrackName { get; set; }
        public int TrackId { get; set; }
        public string TrackDescription { get; }
        public int TrackSize { get; }
        public string TrackDate { get; }
        public bool TrackIsInstalled { get; set; }
        public string TrackCountry { get; set; }
        public string TrackLength { get; set; }
    }
}
