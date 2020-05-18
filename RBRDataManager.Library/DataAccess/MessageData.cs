using RBRDataManager.Library.Internal.DataAccess;
using RBRDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRDataManager.Library.DataAccess
{
    public class MessageData
    {
        public List<MessageModel> GetMessages()
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<MessageModel, dynamic>("dbo.spMessagesGetAll", new { }, "RBRDriverHubData");

            return output;
        }
    }
}
