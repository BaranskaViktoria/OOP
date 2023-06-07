using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon_EF.BLL.DTOs
{
    public class ReplyProductsDTOs 
    {
        public int Id { get; set; } = default!;
        [Required(ErrorMessage = "The Title field is required.")]
        public int CommentProductId { get; set; } = default!;
        [Required(ErrorMessage = "The Title field is required.")]
        public string? TextProductReply { get; set; } = default!;
        [Required(ErrorMessage = "The Title field is required.")]
        public DateTime DateTimeProductReply { get; set; } = default!;
     

 
    }
}
