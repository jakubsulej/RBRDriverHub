using RBRDesktopUI.Library.Models;
using System.Threading.Tasks;

namespace RBRDesktopUI.Library.Api
{
    public interface ITournamentTrackPostEndpoint
    {
        Task PostTrackTournament(TournamentTrackPostModel tournamentTrackPost);
    }
}