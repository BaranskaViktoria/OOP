using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesDatabase.Data.Models;
using SalesDatabase.Data.Seeder;

namespace SalesDaatabase.Data.Configuration
{
    public class SaleConfiguration
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            new SaleSeeder().Seed(builder);
        }
    }
}
