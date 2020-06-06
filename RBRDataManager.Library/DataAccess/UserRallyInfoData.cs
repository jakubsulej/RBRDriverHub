using RBRDataManager.Library.Internal.DataAccess;
using RBRDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRDataManager.Library.DataAccess
{
    public class UserRallyInfoData
    {
        public UserRallyInfoModel GetUserRallyInfoById(string userId)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<UserRallyInfoModel, dynamic>("dbo.spUserRallyInfoGetById", new { Id = userId }, "RBRDriverHubData").FirstOrDefault();

            return output;
        }
    }
}
