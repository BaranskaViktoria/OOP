using BeautySalon_Dapper.DAL.Entities;
using BeautySalon_Dapper.DAL.Entities_Models_;
using BeautySalon_Dapper.DAL.Repositories.Contracts;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon_Dapper.DAL.Repositories
{
    public class SalonCityRepository : GenericRepository<SalonCity>, ISalonCityRepository
    {
        public SalonCityRepository(SqlConnection sqlConnection, IDbTransaction dbtransaction) : base(sqlConnection, dbtransaction, "ServicedManagement.SalonCity")
        {
        }
        public async Task<IEnumerable<Master>> TopFiveSalonCityAsync()
        {
            string sql = @"SELECT TOP 5 * FROM ServicedManagement.SalonCity;";
            var results = await _sqlConnection.QueryAsync<SalonCity>(sql,
                transaction: _dbTransaction);
            return results;
        }
    }
}
