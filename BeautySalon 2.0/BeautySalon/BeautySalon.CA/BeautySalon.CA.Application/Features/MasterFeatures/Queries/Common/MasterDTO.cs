using Application.Common.HATEOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.CA.Application.Features.MasterFeatures.Queries.Common
{
    public class MasterDTO : LinkBaseEntity
    {
        public int Id { get; set; }
        public string? FirstName { get; set; } = default!;
        public string? LastName { get; set; } = default!;
        public string? MastersType { get; set; } = default!;
        public int ServiceID { get; set; } = default!;
        public int SalonID { get; set; } = default!;
        public string? CitySalon { get; set; } = default!;
    }
}
