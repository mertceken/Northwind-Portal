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
    public class ProductService : IProductService
    {
        List<Product> products_ = new List<Product>();
        List<Categories> categoryList = new List<Categories>();
        List<Supplier> suppliersList = new List<Supplier>();
        Product product = new Product();

        public IConfiguration configuration { get; }
        public string _connectionString = "";

        public ProductService(IConfiguration _configuration)
        {
            configuration = _configuration;
            _connectionString = configuration.GetConnectionString("Northwind");
        }


        public async Task<bool> Add(Product product)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(_connectionString))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("ProductName", product.ProductName, DbType.String);
                    parameters.Add("SupplierID", product.SupplierID, DbType.Int32);
                    parameters.Add("CategoryID", product.CategoryID, DbType.Int32);
                    parameters.Add("QuantityPerUnit", product.QuantityPerUnit, DbType.String);
                    parameters.Add("UnitPrice", product.UnitPrice, DbType.Decimal);
                    parameters.Add("UnitsInStock", product.UnitsInStock, DbType.Int32);
                    parameters.Add("UnitsOnOrder", product.UnitsOnOrder, DbType.Int32);
                    parameters.Add("ReorderLevel", product.ReorderLevel, DbType.Int32);
                    parameters.Add("Discontinued", product.Discontinued, DbType.Boolean);


                    const string insertQuery = @"INSERT INTO [dbo].[Products]
                               ([ProductName]
                               ,[SupplierID]
                               ,[CategoryID]
                               ,[QuantityPerUnit]
                               ,[UnitPrice]
                               ,[UnitsInStock]
                               ,[UnitsOnOrder]
                               ,[ReorderLevel]
                               ,[Discontinued])
                         VALUES
                               (@ProductName
                               ,@SupplierID
                               ,@CategoryID
                               ,@QuantityPerUnit
                               ,@UnitPrice
                               ,@UnitsInStock
                               ,@UnitsOnOrder
                               ,@ReorderLevel
                               ,@Discontinued)";

                    await connection.ExecuteAsync(insertQuery, new
                    {
                        product.ProductName,
                        product.SupplierID,
                        product.CategoryID,
                        product.QuantityPerUnit,
                        product.UnitPrice,
                        product.UnitsInStock,
                        product.UnitsOnOrder,
                        product.ReorderLevel,
                        product.Discontinued

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

        public async Task<bool> Delete(int productId)
        {
            Product product = new Product();
            var parameters = new DynamicParameters();
            parameters.Add("ProductID", productId, DbType.Int32);
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync("spProductDelete", parameters, commandType: CommandType.StoredProcedure);
            }

            return true;
        }

        public async Task<Product> GetProductById(int id)
        {
            Product product = new Product();
            var parameters = new DynamicParameters();
            parameters.Add("ProductID", id, DbType.Int32);
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                product = await connection.QueryFirstOrDefaultAsync<Product>("spGetProductById", parameters, commandType: CommandType.StoredProcedure);

            }
            return product;
        }

        public List<Product> GetProducts()
        {
            //SP_Product_CUD
            products_ = new List<Product>();
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                var products = connection.Query<Product>("Select * From Products").ToList();
                if (products!=null && products.Count>0)
                {
                    products_ = products;
                }
            }
            return products_;
        }

        public async Task<bool> Update(Product product)
        {
            
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("ProductID", product.ProductID, DbType.Int32);
                parameters.Add("ProductName", product.ProductName, DbType.String);
                parameters.Add("SupplierID", product.SupplierID, DbType.Int32);
                parameters.Add("CategoryID", product.CategoryID, DbType.Int32);
                parameters.Add("QuantityPerUnit", product.QuantityPerUnit, DbType.String);
                parameters.Add("UnitPrice", product.UnitPrice, DbType.Decimal);
                parameters.Add("UnitsInStock", product.UnitsInStock, DbType.Int32);
                parameters.Add("UnitsOnOrder", product.UnitsOnOrder, DbType.Int32);
                parameters.Add("ReorderLevel", product.ReorderLevel, DbType.Int32);
                parameters.Add("Discontinued", product.Discontinued, DbType.Boolean);


                await connection.ExecuteAsync("spProductUpdate", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }

    

        public List<Categories> GetCategoriesForProducts()
        {
            categoryList = new List<Categories>();
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                var categories = connection.Query<Categories>("Select * from Categories").ToList();
                if (categories!=null && categories.Count>0)
                {
                    categoryList = categories;
                }

                return categoryList;
            }
        }

        public List<Supplier> GetSuppliersForProducts()
        {
            suppliersList = new List<Supplier>();
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                var suppliers = connection.Query<Supplier>("Select * from Suppliers").ToList();
                if (suppliers!=null && suppliers.Count>0)
                {
                    suppliersList = suppliers;
                }
                
            }
            return suppliersList;
        }
    }
}
