using RBRDesktopUI.Library.Models;
using System.Threading.Tasks;

namespace RBRDesktopUI.Library.Api
{
    public interface ITournamentCarPostEndpoint
    {
        Task PostCarTournament(TournamentCarPostModel tournamentCarPost);
    }
}