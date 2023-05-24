using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProjectBeautySalon.Entities
{
    public class Service
    {
        public int ServiceID { get; set; }
        public string? ServiceName { get; set; }
        public string? DescriptionServices { get; set; }
        public  int Price { get; set; }
    }
}



