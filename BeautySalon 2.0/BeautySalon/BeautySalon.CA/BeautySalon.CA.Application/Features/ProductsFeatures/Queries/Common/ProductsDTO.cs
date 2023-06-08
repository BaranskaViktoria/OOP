using Application.Common.HATEOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.CA.Application.Features.ProductsFeatures.Queries.Common
{
    public class ProductsDTO : LinkBaseEntity
    {
        public int Id { get; set; }
        public string? ProductName { get; set; } = default!;
        public string? Description { get; set; } = default!;
        public int Price { get; set; }
    }
}
