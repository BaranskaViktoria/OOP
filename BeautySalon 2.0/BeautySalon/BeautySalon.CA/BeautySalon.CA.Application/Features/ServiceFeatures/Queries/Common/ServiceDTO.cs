using Application.Common.HATEOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.CA.Application.Features.ServiceFeatures.Queries.Common
{
    public class ServiceDTO : LinkBaseEntity
    {
        public int Id { get; set; }
        public string? ServiceName { get; set; } = default!;
        public string? DescriptionServices { get; set; }
        public int Price { get; set; } = default!;
    }
}
