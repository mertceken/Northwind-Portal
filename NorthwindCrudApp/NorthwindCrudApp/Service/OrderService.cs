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
    public class OrderService : IOrderService
    {
        List<Orders> _orders = new List<Orders>();
        Orders orders = new Orders();

        public IConfiguration Configuration { get; }
        public string _connectionString = "";
        public OrderService(IConfiguration configuration)
        {
            Configuration = configuration;
            _connectionString = Configuration.GetConnectionString("Northwind");
        }
        public async Task<bool> Add(Orders order)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(_connectionString))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("CustomerID", order.CustomerID, DbType.String);
                    parameters.Add("EmployeeID", order.EmployeeID, DbType.Int32);
                    parameters.Add("OrderDate", order.OrderDate, DbType.DateTime);
                    parameters.Add("RequiredDate", order.RequiredDate, DbType.DateTime);
                    parameters.Add("ShippedDate", order.ShippedDate, DbType.DateTime);
                    parameters.Add("ShipVia", order.ShipVia, DbType.Int32);
                    parameters.Add("Freight", order.Freight, DbType.Decimal);
                    parameters.Add("ShipName", order.ShipName, DbType.String);
                    parameters.Add("ShipAdress", order.ShipAddress, DbType.String);
                    parameters.Add("ShipCity", order.ShipCity, DbType.String);
                    parameters.Add("ShipRegion", order.ShipRegion, DbType.String);
                    parameters.Add("ShipPostalCode", order.ShipPostalCode, DbType.String);
                    parameters.Add("ShipCountry", order.ShipCountry, DbType.String);

                    const string insertQuery = @"INSERT INTO [dbo].[Orders]
                                       ([CustomerID]
                                       ,[EmployeeID]
                                       ,[OrderDate]
                                       ,[RequiredDate]
                                       ,[ShippedDate]
                                       ,[ShipVia]
                                       ,[Freight]
                                       ,[ShipName]
                                       ,[ShipAddress]
                                       ,[ShipCity]
                                       ,[ShipRegion]
                                       ,[ShipPostalCode]
                                       ,[ShipCountry])
                                 VALUES
                                       (@CustomerID
                                       ,@EmployeeID
                                       ,@OrderDate
                                       ,@RequiredDate
                                       ,@ShippedDate
                                       ,@ShipVia
                                       ,@Freight
                                       ,@ShipName
                                       ,@ShipAddress
                                       ,@ShipCity
                                       ,@ShipRegion
                                       ,@ShipPostalCode
                                       ,@ShipCountry)";
                    await connection.ExecuteAsync(insertQuery, new
                    {
                        order.CustomerID,
                        order.EmployeeID,
                        order.RequiredDate,
                        order.ShippedDate,
                        order.ShipVia,
                        order.Freight,
                        order.ShipName,
                        order.ShipAddress,
                        order.ShipCity,
                        order.ShipRegion,
                        order.ShipPostalCode,
                        order.ShipCountry
                    }, commandType: CommandType.Text);
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                throw;
            }
            

            return true;
        }

        public async Task<bool> Delete(int orderId)
        {
            Orders orders = new Orders();
            var parameters = new DynamicParameters();
            parameters.Add("OrderID", orderId, DbType.Int32);
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync("spOrdersDelete", parameters, commandType: CommandType.StoredProcedure);
            }

            return true;
        }

        public async Task<Orders> GetById(int orderId)
        {
            Orders orders = new Orders();
            var parameters = new DynamicParameters();
            parameters.Add("OrderID", orderId, DbType.Int32);
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                orders = await connection.QueryFirstOrDefaultAsync<Orders>("spGetOrdersById", parameters, commandType: CommandType.StoredProcedure);
            }
            return orders;
        }

        public List<Orders> GetOrders()
        {
            _orders = new List<Orders>();
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                var Orders = connection.Query<Orders>("SELECT  TOP 100 * FROM Orders").ToList();
                if (Orders!=null && Orders.Count>0)
                {
                    _orders = Orders;
                }
            }
            return _orders;
        }

        public async Task<bool> Update(Orders order)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(_connectionString))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("OrderID", order.OrderID, DbType.Int32);
                    parameters.Add("CustomerID", order.CustomerID, DbType.String);
                    parameters.Add("EmployeeID", order.EmployeeID, DbType.Int32);
                    parameters.Add("OrderDate", order.OrderDate, DbType.DateTime);
                    parameters.Add("RequiredDate", order.RequiredDate, DbType.DateTime);
                    parameters.Add("ShippedDate", order.ShippedDate, DbType.DateTime);
                    parameters.Add("ShipVia", order.ShipVia, DbType.Int32);
                    parameters.Add("Freight", order.Freight, DbType.Decimal);
                    parameters.Add("ShipName", order.ShipName, DbType.String);
                    parameters.Add("ShipAddress", order.ShipAddress, DbType.String);
                    parameters.Add("ShipCity", order.ShipCity, DbType.String);
                    parameters.Add("ShipRegion", order.ShipRegion, DbType.String);
                    parameters.Add("ShipPostalCode", order.ShipPostalCode, DbType.String);
                    parameters.Add("ShipCountry", order.ShipCountry, DbType.String);

                    await connection.ExecuteAsync("spOrderUpdate", parameters, commandType: CommandType.StoredProcedure);
                }

                return true;
            }
            catch (Exception ex)
            {
                ex.ToString();
                throw;
            }
            
      
        }

        private DynamicParameters SetParameters(Orders order,int nOperationType)
        {
            DynamicParameters obj = new DynamicParameters();
            obj.Add("@OrderID", order.OrderID);
            obj.Add("@CustomerID", order.CustomerID);
            obj.Add("@EmployeeID", order.EmployeeID);
            obj.Add("@OrderDate", order.OrderDate);
            obj.Add("@RequiredDate", order.RequiredDate);
            obj.Add("@ShippedDate", order.ShippedDate);
            obj.Add("@ShipVia", order.ShipVia);
            obj.Add("@Freight", order.Freight);
            obj.Add("@ShipName", order.ShipName);
            obj.Add("@ShipAddress", order.ShipAddress);
            obj.Add("@ShipCity", order.ShipCity);
            obj.Add("@ShipRegion", order.ShipRegion);
            obj.Add("@ShipPostalCode", order.ShipPostalCode);
            obj.Add("@ShipCountry", order.ShipCountry);

            return obj;

        }
    }
}
