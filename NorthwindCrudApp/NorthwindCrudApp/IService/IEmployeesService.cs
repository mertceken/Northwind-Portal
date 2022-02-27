using NorthwindCrudApp.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NorthwindCrudApp.IService
{
    public interface IEmployeesService
    {
        List<Employee> GetEmployees();

        Task<Employee> GetById(int employeeId);

        Task<bool> Add(Employee employee);

        Task<bool> Update(Employee employee); 

        Task<bool> Delete(int employeeId);  
    }
}
