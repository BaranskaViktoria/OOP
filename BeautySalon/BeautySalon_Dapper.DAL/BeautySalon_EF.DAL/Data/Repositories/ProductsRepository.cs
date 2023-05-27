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
    public class ProductsRepository : GenericRepository<Products>,IProductsRepository
    {
        public ProductsRepository(ProductsContext productsContext): base (productsContext)
        {

        }

        public override Task<Products> GetCompleteEntityAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
