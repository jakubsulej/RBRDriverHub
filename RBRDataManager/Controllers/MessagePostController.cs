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
    [Authorize]

    public class MessagePostController : ApiController
    {
        public void Post(MessagePostModel messagePost)
        {
            MessagePostData data = new MessagePostData();

            //string userId = RequestContext.Principal.Identity.GetUserId();

            data.SaveMessagePost(messagePost);
        }
    }
}
