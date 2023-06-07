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
    public class CommentsProductsSeeder : ISeeder<CommentsProducts>
    {
        private static readonly List<CommentsProducts> commentsProducts = new()
        {
            new CommentsProducts
            {
                Id = 1,
                UserID = 1,
                ProductID = 1,
                Rating = 4,
                CreateTime = DateTime.Now.AddDays(1), 
                Comments = "SUPER"
            }
        };

        public void Seed(EntityTypeBuilder<CommentsProducts> builder) => builder.HasData(commentsProducts);
    }

}
