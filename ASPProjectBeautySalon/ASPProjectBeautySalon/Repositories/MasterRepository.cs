using ASPProjectBeautySalon.Entities;
using ASPProjectBeautySalon.Repositories.Contracts;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProjectBeautySalon.Repositories
{
    public class MasterRepository : GenericRepository<Master>, IMasterRepository
    {
        public MasterRepository(SqlConnection sqlConnection, IDbTransaction dbtransaction) : base(sqlConnection, dbtransaction, "ServicedManagement.Masters")
        {
        }
    }
}
