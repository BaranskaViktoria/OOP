using BeautySalon_ADO.DAL.Models;


namespace BeautySalon_ADO.DAL.Repositories.Contracts
{
    public interface IServiceRepository : IGenericRepository<Service>
    {
       /* Task AddAsync(Master evnt);
        Task ReplaceAsync(Master evnt);
        Task ReplaceAsync(SalonCity evnt);*/
        Task<IEnumerable<Service>> TopFiveServiceAsync();
    }
}
