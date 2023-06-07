using BeautySalon_ADO.DAL.Models;


namespace BeautySalon_ADO.DAL.Repositories.Contracts
{
    public interface IMasterRepository : IGenericRepository<Master>
    {
        Task<IEnumerable<Master>> TopFiveMasterAsync();
    }
}
