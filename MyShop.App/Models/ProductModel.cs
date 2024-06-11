
namespace MyShop.Models
{
    public class ProductModel
    {
        public int IdProduct { get; set; }

        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public string? Category { get; set; }
    }
}
