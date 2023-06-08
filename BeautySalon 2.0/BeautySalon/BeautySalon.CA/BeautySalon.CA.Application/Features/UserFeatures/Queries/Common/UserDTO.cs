using Application.Common.HATEOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.CA.Application.Features.UserFeatures.Queries.Common
{
    public class UserDTO : LinkBaseEntity
    {
        public int Id { get; set; }
        public string? UserFirstName { get; set; } = default!;
        public string? UserLastName { get; set; } = default!;
        public string? UserEmail { get; set; } = default!;
        public string? Paswordd { get; set; } = default!;
    }
}
