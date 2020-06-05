using RBRDataManager.Library.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RBRDataManager.Library.Models;
using System.Web.Http;
using Microsoft.AspNet.Identity;

namespace RBRDataManager.Controllers
{
    [Authorize]
    [RoutePrefix("api/User")]

    public class UserController : ApiController
    {
        public UserModel GetById()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();

            UserData data = new UserData();

            return data.GetUserById(userId).First();
        }
    }
}
