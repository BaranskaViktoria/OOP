using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.CA.Domain.Entities
{
    public class Comments
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int MasterID { get; set; }
        public decimal Rating { get; set; }
        public DateTime CreateTime { get; set; }
        public string? Comment { get; set; }
    }
}