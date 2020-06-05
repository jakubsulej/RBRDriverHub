using RBRDesktopUI.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RBRDesktopUI.Library.Api
{
    public class TournamentCarPostEndpoint : ITournamentCarPostEndpoint
    {
        private IAPIHelper _apiHelper;

        public TournamentCarPostEndpoint(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public async Task PostCarTournament(TournamentCarPostModel tournamentCarPost)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("/api/TournamentCarPost", tournamentCarPost))
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
