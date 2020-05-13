using RBRDataManager.Library.Internal.DataAccess;
using RBRDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRDataManager.Library.DataAccess
{
    public class CarData
    {
        public List<CarModel> GetCars()
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<CarModel, dynamic>("dbo.spCarsGetAll", new { }, "RBRDriverHubData");

            return output;
        }
    }
}
