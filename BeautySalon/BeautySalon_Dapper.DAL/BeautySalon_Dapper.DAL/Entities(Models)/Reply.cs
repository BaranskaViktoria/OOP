using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon_Dapper.DAL.Entities_Models_
{
    public class Reply
    {
        public int Id { get; set; }
        public int CommentId { get; set; }
        public string? TextPeply { get; set; }
        public DateTime DateTimeReply { get; set; }
    }
}
