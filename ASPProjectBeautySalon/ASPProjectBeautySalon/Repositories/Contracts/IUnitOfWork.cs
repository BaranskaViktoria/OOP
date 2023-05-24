namespace ASPProjectBeautySalon.Repositories.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IServiceRepository _serviceRepository { get; }
        void Commit();
        void Dispose();
    }
}
