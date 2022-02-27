using NorthwindCrudApp.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NorthwindCrudApp.IService
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();

        Customer GetById(string customerId);

        Task<bool> Add(Customer customer);

        Customer Update(Customer customer);

        string Delete(string customerId);

    }
}
