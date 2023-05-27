using System.Threading.Tasks;
using BeautySalon_EF.DAL.Data.Repositories;
using BeautySalon_EF.DAL.Interfaces.Repositories;

namespace TeamworkSystem.DataAccessLayer.Interfaces
{
    public interface IUnitOfWork
    {
        IProductsRepository ProductsRepository { get; }

            Task SaveChangesAsync();
    }
}
