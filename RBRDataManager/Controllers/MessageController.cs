using Microsoft.AspNet.Identity;
using RBRDataManager.Library.DataAccess;
using RBRDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RBRDataManager.Controllers
{
    public class MessageController : ApiController
    {
        public List<MessageDBModel> GetById()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();

            MessageData data = new MessageData();

            UserData user = new UserData();

            return data.GetMessages(userId);
        }
    }
}
