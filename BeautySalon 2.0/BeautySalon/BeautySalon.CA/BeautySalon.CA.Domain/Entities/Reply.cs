using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon_ADO.DAL.Models
{
    public class Reply
    {
        public int Id { get; set; }
        public int CommentId { get; set; }
        public string? TextPeply { get; set; }
        public DateTime DateTimeReply { get; set; }
    }
}
