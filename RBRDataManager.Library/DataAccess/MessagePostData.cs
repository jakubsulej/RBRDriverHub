using RBRDataManager.Library.Internal.DataAccess;
using RBRDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRDataManager.Library.DataAccess
{
    public class MessagePostData
    {
        private string adresseeId;

        public void SaveMessagePost(MessagePostModel messagePost)
        {
            List<MessagePostDBModel> details = new List<MessagePostDBModel>();

            SqlDataAccess sql = new SqlDataAccess();

            var AdresseeName = sql.LoadData<UserModel, dynamic>("dbo.spUserLookup", new { Id = adresseeId }, "RBRDriverHubData");

            foreach (var item in messagePost.MessagePostDetails)
            {
                var detail = new MessagePostDBModel
                {
                    MessageId = item.MessageId,
                    MessageSenderId = item.MessageSenderId,
                    MessageSubject = item.MessageSubject,
                    MessageAttachment = item.MessageAttachment,
                    MessageContent = item.MessageContent,
                    MessageDate = item.MessageDate,
                    MessageAdresseeId = item.UserId
                };

                details.Add(detail);

                //sql.SaveData("dbo.spMessageInsert", details, "RBRDriverHubData");
            }
        }
    }
}
