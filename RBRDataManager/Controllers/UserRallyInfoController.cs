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
    [Authorize]

    public class UserRallyInfoController : ApiController
    {
        public UserRallyInfoModel GetById()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();
            UserRallyInfoData data = new UserRallyInfoData();

            return data.GetUserRallyInfoById(userId);
        }
    }
}
