using RBRDesktopUI.Library.Models;
using System.Threading.Tasks;

namespace RBRDesktopUI.Library.Api
{
    public interface ITournamentPostEndpoint
    {
        Task PostTournament(TournamentPostModel tournamentPost);
    }
}