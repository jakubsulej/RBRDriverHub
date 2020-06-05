using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRDesktopUI.Library.Models
{
    public class UserRallyInfoReadModel
    {
        public string UserId { get; set; }
        public string UserLicence { get; set; }
        public int TotalNumberOfKm { get; set; }
        public int EnteredTournaments { get; set; }
        public int FinnishedTournaments { get; set; }
        public int WonTournaments { get; set; }
    }
}
