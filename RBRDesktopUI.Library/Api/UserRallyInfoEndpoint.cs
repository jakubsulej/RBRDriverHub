using RBRDesktopUI.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RBRDesktopUI.Library.Api
{
    public class UserRallyInfoEndpoint : IUserRallyInfoEndpoint
    {
        private IAPIHelper _apiHelper;
        private IUserRallyInfoModel _userRallyInfo;

        public UserRallyInfoEndpoint(IAPIHelper apiHelper, IUserRallyInfoModel userRallyInfo)
        {
            _apiHelper = apiHelper;
            _userRallyInfo = userRallyInfo;
        }

        public async Task GetLoggedInUserRallyInfo()
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync("/api/UserRallyInfo"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<UserRallyInfoModel>();

                    _userRallyInfo.UserLicence = result.UserLicence;
                    _userRallyInfo.EnteredTournaments = result.EnteredTournaments;
                    _userRallyInfo.FinnishedTournaments = result.FinnishedTournaments;
                    _userRallyInfo.TotalNumberOfKm = result.TotalNumberOfKm;
                    _userRallyInfo.WonTournaments = result.WonTournaments;
                    _userRallyInfo.UserId = result.UserId;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
