using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRDesktopUI.Library.Models
{
    public class TournamentTrackPostModel
    {
        public List<TournamentTrackPostDetailModel> TournamentTrackPostDetails { get; set; } = new List<TournamentTrackPostDetailModel>();
    }
}