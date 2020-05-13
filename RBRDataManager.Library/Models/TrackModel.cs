using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRDataManager.Library.Models
{
    public class TrackModel
    {
        public int Id { get; set; }
        public string TrackId { get; set; }
        public string TrackName { get; set; }
        public DateTime TrackDate { get; set; }
        public string TrackDescription { get; set; }
        public bool TrackIsInstalled { get; set; }
        public string TrackCountry { get; set; }
        public string TrackLength { get; set; }
    }
}
