using NorthwindCrudApp.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NorthwindCrudApp.IService
{
    public interface IProductService
    {
        List<Product> GetProducts();

        List<Categories> GetCategoriesForProducts();

        List<Supplier> GetSuppliersForProducts();   

        Task<Product> GetProductById(int id);

        Task<bool> Add(Product product);

        Task<bool> Update(Product product);

        Task<bool> Delete(int productId);
    }
}
