using BeautySalon_EF.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon_EF.DAL.Seeding
{
    public class CommentsProductsSeeder : ISeeder<CommentsProducts>
    {
        private static readonly List<CommentsProducts> commentsProducts = new()
        {
            new CommentsProducts
            {
                Id = 1,
                UserID = 1,
                ProductID = 1,
                Rating = 4.5,
                CreateTime = "25.10.2023 17-50-45,
                Comments = "SUPER"
            }
        };

        public void Seed(EntityTypeBuilder<CommentsProducts> builder) => builder.HasData(commentsProducts);
    }

}
