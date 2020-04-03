using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRTrackFinder.Models
{
    public class TrackModel
    {
        public string TrackName { get; }
        public string TrackDescription { get; }
        public int TrackSize { get; }
        public string TrackDate { get; }
        public bool TrackIsInstalled { get; set; }
    }
}
