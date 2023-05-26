using BeautySalon_Dapper.DAL.Entities;
using BeautySalon_Dapper.DAL.Entities_Models_;
using BeautySalon_Dapper.DAL.Repositories.Contracts;

namespace BeautySalon_Dapper.DAL.Repositories.Contracts
{
    public interface IServiceRepository : IGenericRepository<Service>
    {
        Task AddAsync(Master evnt);
        Task ReplaceAsync(Master evnt);
        Task<IEnumerable<Service>> TopFiveServiceAsync();
    }
}
