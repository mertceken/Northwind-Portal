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
    public class ShippersService : IShipperService
    {
        List<Shippers> shippersList = new List<Shippers>(); 
        Shippers shipper = new Shippers();

        public IConfiguration configuration { get; }
        public string connectionString = "";

        public ShippersService(IConfiguration _configuration)
        {
            configuration = _configuration;
            connectionString = configuration.GetConnectionString("Northwind");
               
        }

        public List<Shippers> GetShippers()
        {
            shippersList = new List<Shippers>();
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                var shippers = connection.Query<Shippers>("Select * from Shippers").ToList();
                if (shippers!=null && shippers.Count>0)
                {
                    shippersList = shippers;
                }
                return shippersList;

            }
        }

        public async Task<Shippers> GetById(int shipperId)
        {
            Shippers shippers = new Shippers();
            var parameters = new DynamicParameters();
            parameters.Add("ShipperID", shipperId, DbType.Int32);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                shippers = await connection.QueryFirstOrDefaultAsync<Shippers>("spGetShipperById", parameters, commandType: CommandType.StoredProcedure);
            }

            return shippers;
            

        }

        public async Task<bool> AddShipper(Shippers shippers)
        {
            
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("CompanyName", shippers.CompanyName, DbType.String);
                parameters.Add("Phone", shippers.Phone, DbType.String);

                const string insertQuery = @"INSERT INTO Shippers (CompanyName,Phone) VALUES(@CompanyName,@Phone)";

                await connection.ExecuteAsync(insertQuery, new { shippers.CompanyName, shippers.Phone }, commandType: CommandType.Text);
            }

            return true;
        }

        public async Task<bool> UpdateShipper(Shippers shippers)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("ShipperID", shippers.ShipperID, DbType.Int32);
                parameters.Add("CompanyName", shippers.CompanyName, DbType.String);
                parameters.Add("Phone", shippers.Phone, DbType.String);

                await connection.ExecuteAsync("spShipperUpdate", parameters, commandType: CommandType.StoredProcedure);
            }

            return true;
        }

        public async Task<bool> DeleteShipper(int shipperId)
        {
            Shippers shippers = new Shippers();
            var parameters = new DynamicParameters();
            parameters.Add("ShipperID", shipperId, DbType.Int32);
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                await connection.ExecuteAsync("spShipperDelete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
