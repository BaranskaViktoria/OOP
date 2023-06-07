using BeautySalon_ADO.DAL.Models;
using BeautySalon_ADO.DAL.Repositories.Contracts;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon_ADO.DAL.Repositories
{
    public class SalonCityRepository : GenericRepository<SalonCity>, ISalonCityRepository
    {
        public SalonCityRepository(SqlConnection sqlConnection, IDbTransaction dbtransaction) : base(sqlConnection, dbtransaction, "ServicedManagement.SalonCity")
        {
        }
        public async Task<IEnumerable<SalonCity>> TopFiveSalonCityAsync()
        {
            string sql = @"SELECT TOP 5 * FROM ServicedManagement.SalonCity;";
            var results = await _sqlConnection.QueryAsync<SalonCity>(sql,
                transaction: _dbTransaction);
            return results;
        }
    }
}
