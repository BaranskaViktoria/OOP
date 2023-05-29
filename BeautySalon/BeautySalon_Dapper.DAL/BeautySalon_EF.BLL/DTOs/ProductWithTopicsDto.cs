using BeautySalon_EF.BLL.DTOs.hateoas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon_EF.BLL.DTOs
{
    public class ProductWithTopicsDto : LinkBaseEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
