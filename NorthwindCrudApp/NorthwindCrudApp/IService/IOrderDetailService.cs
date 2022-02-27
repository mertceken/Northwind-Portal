using NorthwindCrudApp.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NorthwindCrudApp.IService
{
    public interface IOrderDetailService
    {
        List<OrderDetail> GetOrderDetails();

        OrderDetail GetById(int OrderId);

        Task<bool> Add(OrderDetail orderDetail);   

       

      

    }
}
