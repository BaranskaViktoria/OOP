using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesDatabase.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Data.Seeder
{
    public class StoreSeeder : ISeeder<Store>
    {
        private static readonly List<Store> stores = new()
        {
            new Store
            {
                StoreId = 1,
                Name = "Dima's Shop"
            },

          new Store
            {
                StoreId = 2,
                Name = "Rostilav's Shop"
            },
        };

        public void Seed(EntityTypeBuilder<Store> builder) => builder.HasData(stores);
    }
}
