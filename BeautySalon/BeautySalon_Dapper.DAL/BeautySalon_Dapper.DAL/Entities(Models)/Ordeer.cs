using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon_Dapper.DAL.Entities_Models_
{
    public class Ordeer
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int  ServiceID { get; set; }
        public int ProductID { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
