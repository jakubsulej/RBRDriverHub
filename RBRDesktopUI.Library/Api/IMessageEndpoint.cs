using RBRDesktopUI.Library.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RBRDesktopUI.Library.Api
{
    public interface IMessageEndpoint
    {
        Task<List<MessageModel>> GetAll();
    }
}