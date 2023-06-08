using Application.Common.HATEOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.CA.Application.Features.SalonCityFeatures.Queries.Common
{
    public class SalonCityDTO : LinkBaseEntity
    {
        public int Id { get; set; }
        public string? CitySalon { get; set; } = default!;
    }
}
