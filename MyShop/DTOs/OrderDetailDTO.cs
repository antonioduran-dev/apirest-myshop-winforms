using System.ComponentModel.DataAnnotations;

namespace MyShop.DTOs
{
    public class OrderDetailDTO
    {
        public int IdDetail { get; set; } = 0;

        [Required(ErrorMessage = "Product required")]
        public int? IdProduct { get; set; }

        [Required(ErrorMessage = "Quantity required")]
        public int Quantity { get; set; }
    }
}
