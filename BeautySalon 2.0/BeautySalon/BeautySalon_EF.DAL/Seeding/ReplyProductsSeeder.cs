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
    public class ReplyProductsSeeder : ISeeder<ReplyProducts>
    {
        private static readonly List<ReplyProducts> replyProducts = new()
        {
            new ReplyProducts
            {
                Id = 1,
                CommentProductId = 1,
                TextProductReply = "for washing",
                DateTimeProductReply = DateTime.Now.AddDays(1)
            }
        };

        public void Seed(EntityTypeBuilder<ReplyProducts> builder) => builder.HasData(replyProducts);
    }
}
