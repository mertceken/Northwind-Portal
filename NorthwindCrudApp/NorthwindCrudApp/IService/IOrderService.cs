using NorthwindCrudApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindCrudApp.IService
{
    public interface IOrderService
    {
        List<Orders> GetOrders();

        Task<Orders> GetById(int orderId);

        Task<bool> Add(Orders order);

        Task<bool> Update(Orders order);

        Task<bool> Delete(int orderId);

    }
}
