using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRDesktopUI.Library.Models
{
    public class TournamentPostDetailModel
    {
        public int CarId { get; set; }
        public string TrackId { get; set; }
        public int StageOrderInTournament { get; set; }
        public string TournamentName { get; set; }
        public string TournamentDescription { get; set; }
        public DateTime TournamentDateTime { get; set; }
    }
}