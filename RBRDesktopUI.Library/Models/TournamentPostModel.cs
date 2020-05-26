using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRDesktopUI.Library.Models
{
    public class TournamentPostModel
    {
        public List<TournamentPostDetailModel> TournamentPostDetails { get; set; } = new List<TournamentPostDetailModel>();
    }
}