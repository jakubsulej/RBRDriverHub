using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRDataManager.Library.Models
{
    public class TournamentPostDBModel
    {
        public string TournamentId { get; set; }
        public string TournamentName { get; set; }
        public string TournamentDescription { get; set; }
        public DateTime TournamentDate { get; set; }
        public string TournamentUserId { get; set; }
    }
}
