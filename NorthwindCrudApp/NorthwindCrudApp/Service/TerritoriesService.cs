using Dapper;
using Microsoft.Extensions.Configuration;
using NorthwindCrudApp.Data;
using NorthwindCrudApp.IService;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindCrudApp.Service
{
    public class TerritoriesService : ITerritoriesService
    {
        List<Territories> territoriesList = new List<Territories>();
        Territories territory = new Territories();

        public IConfiguration configuration { get; }
        public string connectionString = "";


        public TerritoriesService(IConfiguration configuration_)
        {
            configuration = configuration_;
            connectionString = configuration.GetConnectionString("Northwind");
        }

        public List<Territories> GetTerritories()
        {
            territoriesList = new List<Territories>();
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                var territories = connection.Query<Territories>("Select * from Territories").ToList();
                if (territories != null && territories.Count > 0)
                {
                    territoriesList = territories;
                }

                return territoriesList;
            }
        }

        public async Task<bool> Add(Territories territories)
        {

            try
            {
                using (IDbConnection connection = new SqlConnection(connectionString))
                {
                    var parameters = new DynamicParameters();
               
                    parameters.Add("TerritoryDescription", territory.TerritoryDescription, DbType.String);
                    parameters.Add("RegionID", territory.RegionID, DbType.Int32);

                    const string insertQuery = @"INSERT INTO Territories (TerritoryDescription,RegionID) VALUES(@TerritoryDescription,@RegionID)";

                    await connection.ExecuteAsync(insertQuery, new {  territory.TerritoryDescription, territory.RegionID }, commandType: CommandType.Text);
                }
                return true;
            }
            catch (System.Exception ex)
            {
                ex.ToString();
                throw;
            }
          

        
        }
        public async Task<bool> Update(Territories territories)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(connectionString))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("TerritoryID", territories.TerritoryID, DbType.Int32);
                    parameters.Add("TerritoryDescription", territories.TerritoryDescription, DbType.String);
                    parameters.Add("RegionID", territories.RegionID, DbType.Int32);

                    await connection.ExecuteAsync("spTerritoriesUpdate", parameters, commandType: CommandType.StoredProcedure);
                }

                return true;
            }
            catch (System.Exception)
            {

                throw;
            }


            
        }

        public async Task<Territories> GetById(int territoriesId)
        {
            Territories territories = new Territories();
            var parameters = new DynamicParameters();
            parameters.Add("TerritoryID", parameters, DbType.Int32);
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                territories = await connection.QueryFirstOrDefaultAsync<Territories>("spGetTerritoriesById", parameters, commandType: CommandType.StoredProcedure);
            }

            return territories;
        }
    }
}
