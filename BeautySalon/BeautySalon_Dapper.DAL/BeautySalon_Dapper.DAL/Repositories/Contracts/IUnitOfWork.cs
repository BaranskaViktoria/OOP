namespace BeautySalon_Dapper.DAL.Repositories.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IServiceRepository _serviceRepository { get; }
        IMasterRepository _masterRepository{ get; }
        void Commit();
        void Dispose();
    }
}
