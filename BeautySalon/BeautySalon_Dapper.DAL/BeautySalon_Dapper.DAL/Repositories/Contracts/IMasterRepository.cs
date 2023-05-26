using BeautySalon_Dapper.DAL.Entities;
using BeautySalon_Dapper.DAL.Entities_Models_;

namespace BeautySalon_Dapper.DAL.Repositories.Contracts
{
    internal interface IMasterRepository : IGenericRepository<Master>
    {
        Task<IEnumerable<Master>> TopFiveMasterAsync();
    }
}
