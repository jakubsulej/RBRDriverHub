using RBRDataManager.Library.Internal.DataAccess;
using RBRDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRDataManager.Library.DataAccess
{
    public class TrackData
    {
        public List<TrackModel> GetTracks()
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<TrackModel, dynamic>("dbo.spTracksGetAll", new { }, "RBRDriverHubData");

            return output;
        }

        public TrackModel GetTrackById(int trackId)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<TrackModel, dynamic>("dbo.spTracksGetById", new { Id = trackId }, "RBRDriverHubData").FirstOrDefault();

            return output;
        }
    }
}
