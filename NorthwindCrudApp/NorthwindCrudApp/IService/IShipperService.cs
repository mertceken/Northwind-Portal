using NorthwindCrudApp.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NorthwindCrudApp.IService
{
    public interface IShipperService
    {
        List<Shippers> GetShippers();

        Task<Shippers> GetById(int shipperId);

        Task<bool> AddShipper(Shippers shippers);

        Task<bool> UpdateShipper(Shippers shippers);

        Task<bool> DeleteShipper(int shipperId);
    }
}
