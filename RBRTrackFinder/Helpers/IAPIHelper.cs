using RBRTrackFinder.Models;
using System.Threading.Tasks;

namespace RBRTrackFinder.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}