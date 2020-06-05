using RBRDataManager.Library.Internal.DataAccess;
using RBRDataManager.Library.Models;
using System.Collections.Generic;

namespace RBRDataManager.Library.DataAccess
{
    public class MessageData
    {
        public string messageSenderName;
        public string messageAdresseeName;
        public string messageSenderId;
        public string messageAdresseeId;

        public List<MessageDBModel> GetMessages(string userId)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<MessageDBModel, dynamic>("dbo.spMessagesGetById", new { AdresseeId = userId }, "RBRDriverHubData");

            foreach (var item in output)
            {
                messageAdresseeId = item.MessageAdresseeId;
                messageSenderId = item.MessageSenderId;
            }

            var messageSenderData = sql.LoadData<UserModel, dynamic>("dbo.spUserLookup", new { Id = messageSenderId }, "RBRDriverHubData");

            foreach (var item in messageSenderData)
            {
                messageSenderName = item.FirstName + " " + item.LastName;
            }

            var messageAdresseeData = sql.LoadData<UserModel, dynamic>("dbo.spUserLookup", new { Id = messageAdresseeId }, "RBRDriverHubData");

            foreach (var item in messageAdresseeData)
            {
                messageAdresseeName = item.FirstName + " " + item.LastName;
            }

            foreach (var item in output)
            {
                item.MessageSenderId = messageSenderName;
                item.MessageAdresseeId = messageAdresseeName;
            }

            return output;
        }
    }
}