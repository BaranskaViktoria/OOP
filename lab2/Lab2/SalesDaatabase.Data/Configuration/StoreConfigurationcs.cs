using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesDatabase.Data.Models;
using SalesDatabase.Data.Seeder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDaatabase.Data.Configuration
{
    public class StoreConfigurationcs
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            new StoreSeeder().Seed(builder);
        }
    }
}
