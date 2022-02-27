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
    public class EmployeesService : IEmployeesService
    {
        List<Employee> employeeList = new List<Employee>();
        Employee employee = new Employee();

        public IConfiguration Configuration { get; }
        public string connectionString = "";


        public async Task<bool> Add(Employee employee)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("LastName", employee.LastName, DbType.String);
                parameters.Add("FirstName", employee.FirstName, DbType.String);
                parameters.Add("Title", employee.Title, DbType.String);
                parameters.Add("TitleOfCourtesy", employee.TitleOfCourtesy, DbType.String);
                parameters.Add("BirthDate", employee.BirthDate, DbType.DateTime);
                parameters.Add("HireDate", employee.HireDate, DbType.DateTime);
                parameters.Add("Address", employee.Address, DbType.String);
                parameters.Add("City", employee.City, DbType.String);
                parameters.Add("Region", employee.Region, DbType.String);
                parameters.Add("PostalCode", employee.PostalCode, DbType.String);
                parameters.Add("Country", employee.Country, DbType.String);
                parameters.Add("HomePhone", employee.HomePhone, DbType.String);
                parameters.Add("Extension", employee.Extension, DbType.String);
                parameters.Add("Photo", employee.Photo, DbType.Byte);
                parameters.Add("Notes", employee.Notes, DbType.String);
                parameters.Add("PhotoPath", employee.PhotoPath, DbType.String);

                const string insertQuery = @"INSERT INTO Employees
                               (LastName
                               ,FirstName
                               ,Title
                               ,TitleOfCourtesy
                               ,BirthDate
                               ,HireDate
                               ,Address
                               ,City
                               ,Region
                               ,PostalCode
                               ,Country
                               ,HomePhone
                               ,Extension
                               ,Photo
                               ,Notes
                               ,ReportsTo
                               ,PhotoPath)
                         VALUES
                               (@LastName
                               ,@FirstName
                               ,@Title
                               ,@TitleOfCourtesy
                               ,@BirthDate
                               ,@HireDate
                               ,@Address
                               ,@City
                               ,@Region
                               ,@PostalCode
                               ,@Country
                               ,@HomePhone
                               ,@Extension
                               ,@Photo
                               ,@Notes
                               ,@ReportsTo
                               ,@PhotoPath)";

                await connection.ExecuteAsync(insertQuery, new
                {
                    employee.LastName,
                    employee.FirstName,
                    employee.Title,
                    employee.TitleOfCourtesy,
                    employee.BirthDate,
                    employee.HireDate,
                    employee.Address,
                    employee.City,
                    employee.Region,
                    employee.PostalCode,
                    employee.Country,
                    employee.HomePhone,
                    employee.Extension,
                    employee.Photo,
                    employee.Notes,
                    employee.ReportsTo,
                    employee.PhotoPath,
                },commandType: CommandType.Text);

            }
            return true;
        }

        public async Task<bool> Delete(int employeeId)
        {
            Employee employee = new Employee();
            var parameters = new DynamicParameters();
            parameters.Add("EmployeeID", employeeId, DbType.Int32);
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                await connection.ExecuteAsync("spEmployeeDelete", parameters, commandType: CommandType.StoredProcedure);
            }

            return true;
         
        }

        public async Task<Employee> GetById(int employeeId)
        
        {
            Employee employee = new Employee();
            var parameters = new DynamicParameters();
            parameters.Add("EmployeeID", employeeId, DbType.Int32);
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                employee = await connection.QueryFirstOrDefaultAsync<Employee>("spGetEmployeeById", parameters, commandType: CommandType.StoredProcedure);
            }

            return employee;
        }

        public List<Employee> GetEmployees()
        {
            employeeList = new List<Employee>();

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                var employees = connection.Query<Employee>("Select * from Employees").ToList();

                if (employees!=null && employees.Count>0)
                {
                    employeeList = employees;
                }
            }
            return employeeList;
        }

        public async Task<bool> Update(Employee employee)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(connectionString))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("EmployeeID", employee.EmployeeID, DbType.Int32);
                    parameters.Add("LastName", employee.LastName, DbType.String);
                    parameters.Add("FirstName", employee.FirstName, DbType.String);
                    parameters.Add("Title", employee.Title, DbType.String);
                    parameters.Add("TitleOfCourtesy", employee.TitleOfCourtesy, DbType.String);
                    parameters.Add("BirthDate", employee.BirthDate, DbType.DateTime);
                    parameters.Add("HireDate", employee.HireDate, DbType.DateTime);
                    parameters.Add("Address", employee.Address, DbType.String);
                    parameters.Add("City", employee.City, DbType.String);
                    parameters.Add("Region", employee.Region, DbType.String);
                    parameters.Add("PostalCode", employee.PostalCode, DbType.String);
                    parameters.Add("Country", employee.Country, DbType.String);
                    parameters.Add("HomePhone", employee.HomePhone, DbType.String);
                    parameters.Add("Extension", employee.Extension, DbType.String);
                    parameters.Add("Photo", employee.Photo, DbType.Byte);
                    parameters.Add("Notes", employee.Notes, DbType.String);
                    parameters.Add("ReportsTo", employee.ReportsTo, DbType.Int32);
                    parameters.Add("PhotoPath", employee.PhotoPath, DbType.String);

                    await connection.ExecuteAsync("spEmployeeUpdate", parameters, commandType: CommandType.StoredProcedure);

                }
                return true;
            }
            catch (Exception ex)
            {
                ex.ToString();
                throw;
            }        
           
        }

       
    }
}
