using RBRDesktopUI.Library.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RBRDesktopUI.Library.Api
{
    public interface ICarEndpoint
    {
        Task<List<CarModel>> GetAll();
    }
}