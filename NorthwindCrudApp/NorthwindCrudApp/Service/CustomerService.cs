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
    public class CustomerService : ICustomerService
    {

        List<Customer> customerList = new List<Customer>();
        Customer customer = new Customer();

        public IConfiguration configuration { get; }
        public string connectionString = "";

        public CustomerService(IConfiguration _configuration)
        {
            configuration = _configuration;
            connectionString = configuration.GetConnectionString("Northwind");
        }
        public async Task<bool> Add(Customer customer)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(connectionString))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("CustomerID", customer.CustomerID, DbType.String);
                    parameters.Add("CompanyName", customer.CompanyName, DbType.String);
                    parameters.Add("ContactName", customer.ContactName, DbType.String);
                    parameters.Add("ContactTitle", customer.ContactTitle, DbType.String);
                    parameters.Add("Address", customer.Address, DbType.String);
                    parameters.Add("City", customer.City, DbType.String);
                    parameters.Add("Region", customer.Region, DbType.String);
                    parameters.Add("PostalCode", customer.PostalCode, DbType.String);
                    parameters.Add("Country", customer.Country, DbType.String);
                    parameters.Add("Phone", customer.Phone, DbType.String);
                    parameters.Add("Fax", customer.Fax, DbType.String);

                    const string insertQuery = @"INSERT INTO [dbo].[Customers]
                       ([CustomerID]
                       ,[CompanyName]
                       ,[ContactName]
                       ,[ContactTitle]
                       ,[Address]
                       ,[City]
                       ,[Region]
                       ,[PostalCode]
                       ,[Country]
                       ,[Phone]
                       ,[Fax])
                 VALUES
                       (@CustomerID
                       ,@CompanyName
                       ,@ContactName
                       ,@ContactTitle
                       ,@Address
                       ,@City
                       ,@Region
                       ,@PostalCode
                       ,@Country
                       ,@Phone
                       ,@Fax)";

                    await connection.ExecuteAsync(insertQuery, new
                    {
                        customer.CustomerID,
                        customer.CompanyName,
                        customer.ContactName,
                        customer.ContactTitle,
                        customer.Address,
                        customer.City,
                        customer.Region,
                        customer.PostalCode,
                        customer.Country,
                        customer.Phone,
                        customer.Fax
                    }, commandType: CommandType.Text);
                }

                return true;
            }
            catch (Exception ex)
            {
                ex.ToString();
                throw;
            }

            
        }

        public string Delete(string customerId)
        {
            throw new System.NotImplementedException();
        }

        public Customer GetById(string customerId)
        {
            throw new System.NotImplementedException();
        }

        public List<Customer> GetCustomers()
        {
            customerList = new List<Customer>();
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                var customers = connection.Query<Customer>("Select * from Customers").ToList();
                if (customers!=null && customers.Count>0)
                {
                    customerList = customers;
                }

                return customerList;

            }
        }

        public Customer Update(Customer customer)
        {
            throw new System.NotImplementedException();
        }

       
    }
}
