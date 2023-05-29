using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon_EF.DAL.Entities
{
    public class CommentsProducts
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public  decimal Rating { get; set; }
        public DateTime CreateTime { get; set; }
        public string? Comments { get; set; }
    }
}
