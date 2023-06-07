using BeautySalon_EF.DAL.Entities;
using BeautySalon_EF.DAL.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamworkSystem.DataAccessLayer.Interfaces;

namespace BeautySalon_EF.DAL.Data.Repositories
{
    public class UnitOfWork :IUnitOfWork
    {

        protected readonly ProductsContext databaseContext;


        public IReplyProductsRepository _productsRepository { get; }

        IReplyProductsRepository IUnitOfWork.ProductsRepository => throw new NotImplementedException();

        IReplyProductsRepository IUnitOfWork.ReplyProductsRepository => throw new NotImplementedException();

        ICommentsProductsRepository IUnitOfWork.CommentsRepository => throw new NotImplementedException();

        public async Task SaveChangesAsync()
        {
            await databaseContext.SaveChangesAsync();
        }

        public UnitOfWork(
            ProductsContext databaseContext,
            IReplyProductsRepository productsRepository)
        {
            this.databaseContext = databaseContext;

            _productsRepository = productsRepository;
        }
    }
}
