using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRDesktopUI.Library.Models
{
    public class TournamentTrackPostDetailModel
    {
        public string TournamentId { get; set; }
        public string TrackId { get; set; }
        public int StageOrderInTournament { get; set; }
        public string TournamentStageId { get; set; }
    }
}