using NorthwindCrudApp.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NorthwindCrudApp.IService
{
    public interface ISupplierService
    {
        List<Supplier> GetSuppliers();

        Task<Supplier> GetById(int supplierId);

        Task<bool> AddSupplier(Supplier supplier);

        Task<bool> UpdateSupplier(Supplier supplier); 

        Task<bool> Delete(int supplierId);   

    }
}
