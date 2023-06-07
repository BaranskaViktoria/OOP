using BeautySalon_EF.DAL.Entities;
using BeautySalon_EF.DAL.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon_EF.DAL.Seeding
{
    public class ProductsSeeder : ISeeder<Products>
    {
        private static readonly List<Products> products = new()
        {
            new Products
            {
                Id = 1,
                ProductName = "Soap",
                Description = "for washing",
                Price = 45
            }
        };

        public void Seed(EntityTypeBuilder<Products> builder) => builder.HasData(products);
    }
}