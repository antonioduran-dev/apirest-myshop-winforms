using System.ComponentModel.DataAnnotations;

namespace MyShop.DTOs
{
    public class UserDTO
    {
        public int IdUser { get; set; }

        public int? IdType { get; set; }

        public string Name { get; set; } = null!;

        public string Address { get; set; } = null!;

        [RegularExpression("^[0-9]{10}$", ErrorMessage = "Phone must contains only numbers, and Max. 10 digits.")]
        public string? Phone { get; set; }

        [RegularExpression(@"^[\w\.-]+@[a-zA-Z\d\.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Email incorrect.")]
        public string? Email { get; set; }
    }
}
