using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon_EF.BLL.DTOs
{
    public class ReplyProductsWithDTOs
    {
        public int Id { get; set; } 
        public IEnumerable<CommentsProductsDTOs>  CommentProductId { get; set; }
        public string? TextProductReply { get; set; } 

        public DateTime DateTimeProductReply { get; set; }


    }
}
