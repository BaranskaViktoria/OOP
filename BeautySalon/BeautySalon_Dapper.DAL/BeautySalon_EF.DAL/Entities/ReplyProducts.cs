using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon_EF.DAL.Entities
{
    public class ReplyProducts
    {
        public int Id { get; set; }
        public int CommentProductId { get; set; }
        public string? TextProductReply { get; set; }
        public DateTime DateTimeProductReply { get; set; }
    }
}
