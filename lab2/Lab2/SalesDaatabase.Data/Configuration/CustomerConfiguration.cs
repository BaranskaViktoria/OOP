using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesDatabase.Data.Seeder;
using SalesDatabase.Data.Models;


namespace SalesDatabase.Data.Configuration
{
    public class CustomerConfiguration
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            new CustomerSeeder().Seed(builder);
        }

    }
}
