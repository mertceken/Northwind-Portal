using Dapper;
using Microsoft.Extensions.Configuration;
using NorthwindCrudApp.Data;
using NorthwindCrudApp.IService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindCrudApp.Service
{
    public class OrderDetailService : IOrderDetailService
    {
        List<OrderDetail> orderDetailList = new List<OrderDetail>();    
        OrderDetail orderdetail = new OrderDetail();    

        public IConfiguration Configuration { get; }
        public string connectionString = "";

        public OrderDetailService(IConfiguration configuration)
        {
            Configuration = configuration;
            connectionString = Configuration.GetConnectionString("Northwind");
        }

        public async Task<bool> Add(OrderDetail orderDetail)
        {
            
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("OrderID", orderdetail.OrderID, DbType.Int32);
                parameters.Add("ProductID", orderdetail.ProductID, DbType.Int32);
                parameters.Add("UnitPrice", orderdetail.UnitPrice, DbType.Decimal);
                parameters.Add("Quantity", orderdetail.Quantity, DbType.Int32);
                parameters.Add("Discount", orderdetail.Discount, DbType.Single);

                const string insertQuery = @"INSERT INTO [Order Details]
                       (OrderID
                       ,ProductID
                       ,UnitPrice
                       ,Quantity
                       ,Discount)
                        VALUES
                       (@OrderID
                       ,@ProductID
                       ,@UnitPrice
                       ,@Quantity
                       ,@Discount)";

                await connection.ExecuteAsync(insertQuery, new
                {
                    orderdetail.OrderID,
                    orderdetail.ProductID,
                    orderdetail.UnitPrice,
                    orderdetail.Quantity,
                    orderdetail.Discount
                }, commandType: CommandType.Text);
            }

            return true;
        }

    

        public OrderDetail GetById(int OrderId)
        {
            orderdetail = new OrderDetail();
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                var OrderDetails = connection.Query<OrderDetail>("Select * from [Order Details] Where OrderID" + OrderId).ToList();
                if (OrderDetails != null && OrderDetails.Count>0)
                {
                    orderdetail = OrderDetails.FirstOrDefault();
                }

            }

            return orderdetail;
        }

        public List<OrderDetail> GetOrderDetails()
        {
            orderDetailList = new List<OrderDetail>();

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                var OrderDetails = connection.Query<OrderDetail>("Select * from [Order Details]").ToList();

                if (OrderDetails!=null && OrderDetails.Count>0)
                {
                    orderDetailList = OrderDetails;
                }

                return orderDetailList;
            }
        }


       
    }
}
