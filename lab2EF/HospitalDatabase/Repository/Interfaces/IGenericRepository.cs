using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDatabase.Repository.Interfaces
{
    public interface IGenericRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity? Get(object id); // 'object' for composite PK
        void Add(TEntity entity);
        void Update(TEntity dbEntity, TEntity entity);
        void Delete(TEntity entity);
    }

}
