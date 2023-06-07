
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeautySalon_ADO.DAL.Models;
using BeautySalon_ADO.DAL.Repositories.Contracts;

namespace BeautySalon_ADO.DAL.Repositories
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
