using BeautySalon_EF.BLL.DTOs.hateoas;
using System.ComponentModel.DataAnnotations;


namespace BeautySalon_EF.BLL.DTOs
{
    public class ProductsDTOs : LinkBaseEntity
    {
        public int Id { get; set; }= default!;
        [Required(ErrorMessage = "The Title field is required.")]
        public string ProductName { get; set;} = default!;
        [Required(ErrorMessage = "The Title field is required.")]
        public string Description { get; set; } = default!;
        [Required(ErrorMessage = "The Title field is required.")]
        public int Price { get; set; }

    }
}
