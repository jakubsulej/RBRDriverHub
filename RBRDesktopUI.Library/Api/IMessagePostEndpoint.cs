using RBRDesktopUI.Library.Models;
using System.Threading.Tasks;

namespace RBRDesktopUI.Library.Api
{
    public interface IMessagePostEndpoint
    {
        Task PostMessage(MessagePostModel messagePost);
    }
}