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
    //[Authorize]

    public class CarController : ApiController
    {
        public List<CarModel> Get()
        {
            CarData data = new CarData();

            return data.GetCars();
        }
    }
}
