using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon_EF.BLL.DTOs.hateoas
{
    public class LinkBaseEntity
    {
        public IList<Link> Links = new List<Link>();
    }
}
