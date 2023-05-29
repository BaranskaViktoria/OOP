using BeautySalon_EF.DAL.Entities;
using BeautySalon_EF.DAL.Seeding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon_EF.DAL.Configuration
{
    public class CommentsProductsConfiguration : IEntityTypeConfiguration<CommentsProducts>
    {

        public void Configure(EntityTypeBuilder<CommentsProducts> builder)
        {
            builder.Property(project => project.Id)
                   .UseIdentityColumn()
                   .IsRequired();

            builder.Property(project => project.UserID)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(project => project.ProductID)
                   .HasMaxLength(50);

            builder.Property(project => project.Rating)
                  .IsRequired()
                .HasMaxLength(50);

            builder.Property(project => project.CreateTime)
                .IsRequired()
              .HasMaxLength(50);

            builder.Property(project => project.Comments)
            .IsRequired()
          .HasMaxLength(50);


            new CommentsProductsSeeder().Seed(builder);
        }
    }
}
