using Application.Common.HATEOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.CA.Application.Features.CommentsProductsFeatures.Queries.Common
{
    public class CommentsProductsDTO : LinkBaseEntity
    {
        public int Id { get; set; }
        public int UserID { get; set; } = default!;
        public int ProductID { get; set; } = default!;
        public decimal Rating { get; set; } = default!;
        public DateTime CreateTime { get; set; }
        public string? Comments { get; set; } = default!;
    }
}
