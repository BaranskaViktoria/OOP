using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon_EF.BLL.DTOs
{
    public class CommentsProductsDTOs
    {
        public int Id { get; set; } = default!;
        [Required(ErrorMessage = "The Title field is required.")]
        public int UserID { get; set; } = default!;
        [Required(ErrorMessage = "The Title field is required.")]
        public int ProductID { get; set; } = default!;
        [Required(ErrorMessage = "The Title field is required.")]
        public decimal Rating { get; set; } = default!;
        [Required(ErrorMessage = "The Title field is required.")]
        public DateTime CreateTime { get; set; } = default!;
        [Required(ErrorMessage = "The Title field is required.")]

        public string? Comments { get; set; } = default!;
        [Required(ErrorMessage = "The Title field is required.")]
        public int Price { get; set; }
    }
}
