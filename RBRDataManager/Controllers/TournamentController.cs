using RBRDataManager.Library.Models;
using RBRDataManager.Library.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RBRDataManager.Controllers
{
    //[Authorize]

    public class TournamentController : ApiController
    {
        public List<TournamentModel> Get()
        {
            TournamentData data = new TournamentData();

            return data.GetTournaments();
        }
    }
}
