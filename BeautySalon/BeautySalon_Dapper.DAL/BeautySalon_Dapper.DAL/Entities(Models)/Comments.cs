using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon_Dapper.DAL.Entities_Models_
{
    public class Comment
    {
        public int Id { get; set; }
        public  int UserID { get; set; }
        public  int  MasterID { get; set; }
        public decimal Rating{ get; set; }
        public DateTime CreateTime { get; set; }
        public string? Comments { get; set; }
    }
}
