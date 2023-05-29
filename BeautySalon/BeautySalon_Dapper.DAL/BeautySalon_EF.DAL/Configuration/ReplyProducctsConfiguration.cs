using BeautySalon_EF.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon_EF.DAL.Configuration
{
    public class ReplyProducctsConfiguration : IEntityTypeConfiguration<ReplyProducts>
    {

        public void Configure(EntityTypeBuilder<ReplyProducts> builder)
        {
            builder.Property(project => project.Id)
                   .UseIdentityColumn()
                   .IsRequired();

            builder.Property(project => project.CommentProductId)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(project => project.TextProductReply)
                   .HasMaxLength(50);

            builder.Property(project => project.DateTimeProductReply)
                  .IsRequired();



            new ProductsConfiguration().Seed(builder);
        }
    }
}
