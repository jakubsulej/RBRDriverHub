using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRDataManager.Library.Models
{
    public class TournamentModel
    {
        public int Id { get; set; }
        public string TournamentName { get; set; }
        public string TournamentDescription { get; set; }
        public DateTime TournamentDate { get; set; }
    }
}
