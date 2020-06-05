using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRDesktopUI.Library.Models
{
    public class TournamentCarPostModel
    {
        public List<TournamentCarPostDetailModel> TournamentCarPostDetails { get; set; } = new List<TournamentCarPostDetailModel>();
    }
}
