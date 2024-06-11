using MyShop.Models;

namespace MyShop.DTOs
{
    public class OrderDTO
    {
        public int IdOrder { get; set; }

        public int? IdUser { get; set; }

        public decimal Total { get; set; }

        public DateTime Date { get; set; }

        public ICollection<OrderDetailDTO> OrderDetails { get; set; } = new List<OrderDetailDTO>();

    }
}
