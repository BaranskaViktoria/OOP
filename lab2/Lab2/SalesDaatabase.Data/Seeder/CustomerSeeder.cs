using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesDatabase.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Data.Seeder
{
    public class CustomerSeeder : ISeeder<Customer>
    {
        private static readonly List<Customer> customers = new()
        {
            new Customer
            {
                CustomerId = 1,
                CreditCardNumber = "0000 0000 0000 0000",
                Email = "first@gmail.com",
                Name = "Tom",
            },

            new Customer
            {
                CustomerId = 2,
                CreditCardNumber = "1111 1111 1111 1111",
                Email = "second@gmail.com",
                Name = "John"
            }
        };

        public void Seed(EntityTypeBuilder<Customer> builder) => builder.HasData(customers);
    }
}
