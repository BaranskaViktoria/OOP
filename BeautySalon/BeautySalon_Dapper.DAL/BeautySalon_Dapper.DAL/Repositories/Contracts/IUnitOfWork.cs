namespace BeautySalon_Dapper.DAL.Repositories.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IServiceRepository _serviceRepository { get; }
        IMasterRepository _masterRepository { get; }
        ISalonCityRepository _saloncityRepository { get; }
        void Commit();
        void Dispose();
    }
}
