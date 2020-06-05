using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RBRDataManager.Library.Models
{
    public class TournamentTrackPostDetailModel
    {
        public int TrackId { get; set; }
        public int StageOrderInTournament { get; set; }
        public string TournamentId { get; set; }
        public string TournamentStageId { get; set; }
    }
}