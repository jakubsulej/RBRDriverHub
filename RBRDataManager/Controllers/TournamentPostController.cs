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

    public class TournamentPostController : ApiController
    {
        public void Post(TournamentPostModel tournamentPost)
        {
            TournamentPostData data = new TournamentPostData();

            string userId = RequestContext.Principal.Identity.GetUserId();

            data.SaveTournamentPost(tournamentPost, userId);
        }
    }
}
