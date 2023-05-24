using ASPProjectBeautySalon.Entities;

namespace ASPProjectBeautySalon.Repositories.Contracts
{
    public interface IServiceRepository : IGenericRepository<Service>
    {
        Task<IEnumerable<Service>> TopFiveServiceAsync();
    }
}
