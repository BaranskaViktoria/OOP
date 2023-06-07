using BeautySalon_ADO.DAL.Repositories.Contracts;
using System.Data;

namespace BeautySalon_ADO.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        
        readonly IDbTransaction _dbTransaction;

        public UnitOfWork(IDbTransaction dbTransaction, IServiceRepository serviceRepository, IMasterRepository masterRepository, ISalonCityRepository saloncityRepository)
        {
            _dbTransaction = dbTransaction;
            _serviceRepository = serviceRepository;
            _masterRepository = masterRepository;
            _saloncityRepository = saloncityRepository;
        }

        public IServiceRepository _serviceRepository { get; set; }

        public IMasterRepository _masterRepository { get; set; }

        public ISalonCityRepository _saloncityRepository { get; set; }

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
    }
}