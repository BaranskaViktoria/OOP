using BeautySalon_EF.DAL.Entities;
using BeautySalon_EF.DAL.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamworkSystem.DataAccessLayer.Data.Repositories;

namespace BeautySalon_EF.DAL.Data.Repositories
{
    public class ReplyProductsRepository : GenericRepository<ReplyProducts>, IReplyProductsRepository
    {
        public ReplyProductsRepository(ProductsContext replyproductsContext) : base(replyproductsContext)
        {

        }

        public override Task<ReplyProducts> GetCompleteEntityAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
