using Dapper;
using RBRDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRDataManager.Library.Internal.DataAccess
{
    internal class SimpleDataAccess
    {
        public string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public List<UserModel> GetUserName(string userId, string connectionStringName)
        {
            string connectionString = GetConnectionString(connectionStringName);

            using (IDbConnection con = new SqlConnection(connectionString))
            {
                string sql = $"Select * from [dbo].User Where Id = { userId }";

                var details = con.Query<UserModel>(sql).ToList();

                return details;
            }
        }
    }
}
