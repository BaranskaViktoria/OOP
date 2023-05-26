using BeautySalon_Dapper.DAL.Entities;
using BeautySalon_Dapper.DAL.Repositories.Contracts;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace BeautySalon_Dapper.DAL.Repositories
{
    public class ServiceRepository : GenericRepository<Service>, IServiceRepository
    {
        public ServiceRepository(SqlConnection sqlConnection, IDbTransaction dbtransaction) : base(sqlConnection, dbtransaction, "ServicedManagement.Serviced")
        {
        }

        public async Task<IEnumerable<Service>> TopFiveServiceAsync()
        {
            string sql = @"SELECT TOP 5 * FROM ServicedManagement.Servised;";
            var results = await _sqlConnection.QueryAsync<Service>(sql,
                transaction: _dbTransaction);
            return results;
        }
    }
}
