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
        public string TrackDescription { get; set; }
        public int TrackSize { get; set; }
        public string TrackDate { get; set; }
        public bool TrackIsInstalled { get; set; }
    }
}
