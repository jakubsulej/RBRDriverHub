using RBRDataManager.Library.Internal.DataAccess;
using RBRDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRDataManager.Library.DataAccess
{
    public class TournamentPostData
    {
        public void SaveTournamentPost(TournamentPostModel tournamentPost, string userId)
        {
            List<TournamentPostDBModel> details = new List<TournamentPostDBModel>();

            SqlDataAccess sql = new SqlDataAccess();

            foreach (var item in tournamentPost.TournamentPostDetails)
            {
                var detail = new TournamentPostDBModel
                {
                    TournamentId = item.TournamentId,
                    TournamentDescription = item.TournamentDescription,
                    TournamentDate = item.TournamentDate,
                    TournamentName = item.TournamentName,
                    TournamentUserId = item.TournamentUserId
                };

                details.Add(detail);

                sql.SaveData("dbo.spTournamentInsert", details, "RBRDriverHubData");
            }
        }
    }
}
