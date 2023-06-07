using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon_EF.BLL.DTOs.Responses
{
    public class CommentsProductsResponse
    {
        public int Id { get; set; } = default!;
        public int UserID { get; set; }
        public IEnumerable<ProductsDTOs> ProductID { get; set; }
        public decimal Rating { get; set; }
        public DateTime CreateTime { get; set; }
        public string? Comments { get; set; }
        public int Price { get; set; }
    }
}
