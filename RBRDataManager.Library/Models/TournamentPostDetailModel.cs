using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RBRDataManager.Library.Models
{
    public class TournamentPostDetailModel
    {
        public string TournamentId { get; set; }
        public string TournamentName { get; set; }
        public string TournamentDescription { get; set; }
        public DateTime TournamentDate { get; set; }
        public string TournamentUserId { get; set; }
    }
}