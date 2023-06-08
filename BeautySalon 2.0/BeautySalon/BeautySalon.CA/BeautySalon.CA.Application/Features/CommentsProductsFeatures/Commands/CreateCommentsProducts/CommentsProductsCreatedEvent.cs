using BeautySalon.CA.Domain.Common;
using BeautySalon_EF.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.CA.Application.Features.CommentsProductsFeatures.Commands.CreateCommentsProducts
{
    public class CommentsProductsCreatedEvent : BaseEvent
    {
        public CommentsProducts CommentsProducts { get; }

        public CommentsProductsCreatedEvent(CommentsProducts commentsProducts)
        {
            CommentsProducts = commentsProducts;
        }
    }
}
