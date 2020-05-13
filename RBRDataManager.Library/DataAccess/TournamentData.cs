using RBRDataManager.Library.Internal.DataAccess;
using RBRDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRDataManager.Library.DataAccess
{
    public class TournamentData
    {
        public List<TournamentModel> GetTournaments()
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<TournamentModel, dynamic>("dbo.spTournamentsGetAll", new { }, "RBRDriverHubData");

            return output;
        }
    }
}
