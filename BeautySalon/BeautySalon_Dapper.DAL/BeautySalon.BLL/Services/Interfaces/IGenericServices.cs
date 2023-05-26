using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeautySalon_Dapper.DAL.Entities;

namespace BeautySalon.BLL.Services.Interfaces
{
    public interface IGenericService<TEntity>
    {
        Task<Guid> CreateAsync(TEntity entity);
        Task<TEntity> GetAsync(Guid id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(Guid id);

        void Dispose();
    }
}
