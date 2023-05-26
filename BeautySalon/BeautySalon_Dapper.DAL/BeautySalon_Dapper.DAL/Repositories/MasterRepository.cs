using BeautySalon_Dapper.DAL.Entities;
using BeautySalon_Dapper.DAL.Repositories.Contracts;
using BeautySalon_Dapper.DAL.Repositories;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeautySalon_Dapper.DAL.Entities_Models_;

namespace eautySalon_Dapper.DAL.Repositories
{
    public class MasterRepository : GenericRepository<Master>,IMasterRepository
    {
        public MasterRepository(SqlConnection sqlConnection, IDbTransaction dbtransaction) : base(sqlConnection, dbtransaction, "ServicedManagement.Masters")
        {
        }
       
        public async Task<IEnumerable<Master>> TopFiveMasterAsync()
        {
            string sql = @"SELECT TOP 5 * FROM ServicedManagement.Masters;";
            var results = await _sqlConnection.QueryAsync<Master>(sql,
                transaction: _dbTransaction);
            return results;
        }
    }
}
