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
    public class TrackController : ApiController
    {
        public List<TrackModel> Get()
        {
            TrackData data = new TrackData();

            return data.GetTracks();
        }
    }
}
