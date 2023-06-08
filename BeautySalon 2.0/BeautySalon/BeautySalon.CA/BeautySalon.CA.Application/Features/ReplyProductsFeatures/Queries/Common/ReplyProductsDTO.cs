using Application.Common.HATEOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.CA.Application.Features.ReplyProductsFeatures.Queries.Common
{
    public class ReplyProductsDTO : LinkBaseEntity
    {
        public int Id { get; set; }
        public int CommentProductId { get; set; } = default!;
        public string? TextProductReply { get; set; } = default!;
        public DateTime DateTimeProductReply { get; set; }
    }
}
