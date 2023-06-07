using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BeautySalon_EF.DAL.Entities;
using BeautySalon_EF.DAL.Seeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BeautySalon_EF.DAL.Configuration
{
    public class ProductsConfiguration : IEntityTypeConfiguration<Products>
    {

        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.Property(project => project.Id)
                   .UseIdentityColumn()
                   .IsRequired();

            builder.Property(project => project.ProductName)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(project => project.Description)
                   .HasMaxLength(50);

            builder.Property(project => project.Price)
                  .IsRequired()
                .HasMaxLength(50);


            new ProductsSeeder().Seed(builder);
        }
    }
}