using RBRDesktopUI.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RBRDesktopUI.Library.Api
{
    public class TournamentPostEndpoint : ITournamentPostEndpoint
    {
        private IAPIHelper _apiHelper;

        public TournamentPostEndpoint(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public async Task PostTournament(TournamentPostModel tournamentPost)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("/api/TournamentPost", tournamentPost))
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
