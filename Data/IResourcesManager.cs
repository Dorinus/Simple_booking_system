using System.Collections.Generic;
using System.Threading.Tasks;
using Simple_booking_system.Models;

namespace Simple_booking_system.Data
{
    public interface IResourcesManager
    {
        Task<IList<Resource>> GetResources();
    }
}