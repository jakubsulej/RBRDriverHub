using RBRDataManager.Library.Internal.DataAccess;
using RBRDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRDataManager.Library.DataAccess
{
    public class TournamentTrackPostData
    {
        public void SaveTournamentTrackPost(TournamentTrackPostModel tournamentTrackPost)
        {
            List<TournamentTrackPostDBModel> details = new List<TournamentTrackPostDBModel>();

            SqlDataAccess sql = new SqlDataAccess();

            foreach (var item in tournamentTrackPost.TournamentTrackPostDetails)
            {
                var detail = new TournamentTrackPostDBModel
                {
                    TrackId = item.TrackId,
                    TournamentId = item.TournamentId,
                    StageOrderInTournament = item.StageOrderInTournament,
                    TournamentStageId = item.TournamentStageId
                };

                details.Add(detail);

                sql.SaveData("dbo.spTournamentTrackInsert", detail, "RBRDriverHubData");
            }
        }
    }
}
