using RBRDesktopUI.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RBRDesktopUI.Library.Api
{
    public class TournamentTrackPostEndpoint : ITournamentTrackPostEndpoint
    {
        private IAPIHelper _apiHelper;

        public TournamentTrackPostEndpoint(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public async Task PostTrackTournament(TournamentTrackPostModel tournamentTrackPost)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("/api/TournamentTrackPost", tournamentTrackPost))
            {
                if (response.IsSuccessStatusCode)
                {
                    //Log succesfull call?
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
