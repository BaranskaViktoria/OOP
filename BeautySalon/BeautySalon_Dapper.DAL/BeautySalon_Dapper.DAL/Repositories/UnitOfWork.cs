using BeautySalon_Dapper.DAL.Repositories.Contracts;
using System.Data;

namespace BeautySalon_Dapper.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public IServiceRepository _serviceRepository { get; }

        IServiceRepository IUnitOfWork._serviceRepository => throw new NotImplementedException();

        IMasterRepository IUnitOfWork._masterRepository => throw new NotImplementedException();

        readonly IDbTransaction _dbTransaction;

        public UnitOfWork(
           IServiceRepository serviceRepository,
           IDbTransaction dbTransaction)
        {
            _serviceRepository = serviceRepository;
            _dbTransaction = dbTransaction;
        }

        public void Commit()
        {
            try
            {
                _dbTransaction.Commit();
                // By adding this we can have muliple transactions as part of a single request
                //_dbTransaction.Connection.BeginTransaction();
            }
            catch (Exception ex)
            {
                _dbTransaction.Rollback();
                Console.WriteLine(ex.Message);
            }
        }
        public void Dispose()
        {
            //Close the SQL Connection and dispose the objects
            _dbTransaction.Connection?.Close();
            _dbTransaction.Connection?.Dispose();
            _dbTransaction.Dispose();
        }

        void IUnitOfWork.Commit()
        {
            throw new NotImplementedException();
        }

        void IUnitOfWork.Dispose()
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}