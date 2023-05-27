using BeautySalon_EF.DAL.Configuration;
using BeautySalon_EF.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon_EF.DAL.Data
{
    public class ProductsContext:DbContext
    {
        public DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ProductConfiguration());

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Initial Catalog=BeautySalon2;Trusted_Connection=True;");
            }
        }

        public ProductsContext(DbContextOptions<ProductsContext> options)
            : base(options)
        {
        }
    }

}
