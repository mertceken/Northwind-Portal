using NorthwindCrudApp.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NorthwindCrudApp.IService
{
    public interface ITerritoriesService
    {
        List<Territories> GetTerritories();

        Task<bool> Add(Territories territories);

        Task<bool> Update(Territories territories);

        Task<Territories> GetById(int territoriesId);
    }
}
