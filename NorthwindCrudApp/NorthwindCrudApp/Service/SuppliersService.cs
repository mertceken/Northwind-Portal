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
    public class SuppliersService : ISupplierService
    {
        List<Supplier> suppliersList = new List<Supplier>();

        Supplier supplier = new Supplier();

        public IConfiguration configuration { get; }
        public string connectionString = "";

        public SuppliersService(IConfiguration configuration_)
        {
            configuration = configuration_;
            connectionString = configuration.GetConnectionString("Northwind");
        }

        public List<Supplier> GetSuppliers()
        {
            suppliersList = new List<Supplier>();

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                var suppliers = connection.Query<Supplier>("Select * from Suppliers").ToList();

                if (suppliers!=null && suppliers.Count()>0)
                {
                    suppliersList = suppliers;
                }
            }

            return suppliersList;
        }

        public async Task<Supplier> GetById(int supplierId)
        {
            Supplier supplier = new Supplier();
            var parameters = new DynamicParameters();
            parameters.Add("SupplierID", supplierId, DbType.Int32);
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                supplier = await connection.QueryFirstOrDefaultAsync<Supplier>("spGetSupplierById", parameters, commandType: CommandType.StoredProcedure);
            }
            return supplier;    
        }

        public async Task<bool> AddSupplier(Supplier supplier)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("CompanyName", supplier.CompanyName, DbType.String);
                parameters.Add("ContactName", supplier.ContactName, DbType.String);
                parameters.Add("ContactTitle", supplier.ContactTitle, DbType.String);
                parameters.Add("Address", supplier.Address, DbType.String);
                parameters.Add("City", supplier.City, DbType.String);
                parameters.Add("Region", supplier.Region, DbType.String);
                parameters.Add("PostalCode", supplier.PostalCode, DbType.String);
                parameters.Add("Country", supplier.Country, DbType.String);
                parameters.Add("Phone", supplier.Phone, DbType.String);
                parameters.Add("Fax", supplier.Fax, DbType.String);
                parameters.Add("HomePage", supplier.HomePage, DbType.String);

                const string insertQuery = @"INSERT INTO Suppliers
                       (CompanyName
                       ,ContactName
                       ,ContactTitle
                       ,Address
                       ,City
                       ,Region
                       ,PostalCode
                       ,Country
                       ,Phone
                       ,Fax
                       ,HomePage)
                 VALUES
                       (@CompanyName
                       ,@ContactName
                       ,@ContactTitle
                       ,@Address
                       ,@City
                       ,@Region
                       ,@PostalCode
                       ,@Country
                       ,@Phone
                       ,@Fax
                       ,@HomePage)";
                await connection.ExecuteAsync(insertQuery, new
                {
                    supplier.CompanyName,
                    supplier.ContactName,
                    supplier.ContactTitle,
                    supplier.Address,
                    supplier.City,
                    supplier.Region,    
                    supplier.PostalCode,
                    supplier.Country,
                    supplier.Phone,
                    supplier.Fax,
                    supplier.HomePage
                }, commandType: CommandType.Text);
            }

            return true;
        }

        public async Task<bool> UpdateSupplier(Supplier supplier)
        {
          

            try
            {
                using (IDbConnection connection = new SqlConnection(connectionString))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("SupplierID", supplier.SupplierID, DbType.Int32);
                    parameters.Add("CompanyName", supplier.CompanyName, DbType.String);
                    parameters.Add("ContactName", supplier.ContactName, DbType.String);
                    parameters.Add("ContactTitle", supplier.ContactTitle, DbType.String);
                    parameters.Add("Address", supplier.Address, DbType.String);
                    parameters.Add("City", supplier.City, DbType.String);
                    parameters.Add("Region", supplier.Region, DbType.String);
                    parameters.Add("PostalCode", supplier.PostalCode, DbType.String);
                    parameters.Add("Country", supplier.Country, DbType.String);
                    parameters.Add("Phone", supplier.Phone, DbType.String);
                    parameters.Add("Fax", supplier.Fax, DbType.String);
                    parameters.Add("HomePage", supplier.HomePage, DbType.String);

                    await connection.ExecuteAsync("spSupplierUpdate", parameters, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                throw;
            }

           

            return true;
        }

        public async Task<bool> Delete(int supplierId)
        {
            Supplier supplier = new Supplier();
            var parameters = new DynamicParameters();
            parameters.Add("SupplierID", supplierId, DbType.Int32);
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                await connection.ExecuteAsync("spSupplierDelete", parameters, commandType: CommandType.StoredProcedure);

            }
            return true;
        }

        
    }
}
