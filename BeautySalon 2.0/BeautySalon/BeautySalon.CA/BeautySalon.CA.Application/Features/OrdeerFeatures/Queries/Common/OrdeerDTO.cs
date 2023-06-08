using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.CA.Application.Features.OrdeerFeatures.Queries.Common
{
    public class OrdeerDTO
    {
        public int Id { get; set; }
        public int UserID { get; set; } = default!;
        public int ServiceID { get; set; } = default!;
        public int ProductID { get; set; } = default!;
        public DateTime OrderDate { get; set; }
    }
}
