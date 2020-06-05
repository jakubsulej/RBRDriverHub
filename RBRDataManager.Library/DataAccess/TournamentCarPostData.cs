using RBRDataManager.Library.Internal.DataAccess;
using RBRDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRDataManager.Library.DataAccess
{
    public class TournamentCarPostData
    {
        public void SaveTournamentCarPost(TournamentCarPostModel tournamentCarPost)
        {
            List<TournamentCarPostDBModel> details = new List<TournamentCarPostDBModel>();

            SqlDataAccess sql = new SqlDataAccess();

            foreach (var item in tournamentCarPost.TournamentCarPostDetails)
            {
                var detail = new TournamentCarPostDBModel
                {
                    TournamentId = item.TournamentId,
                    CarId = item.CarId
                };

                details.Add(detail);

                sql.SaveData("dbo.spTournamentCarInsert", detail, "RBRDriverHubData");
            }
        }
    }
}
