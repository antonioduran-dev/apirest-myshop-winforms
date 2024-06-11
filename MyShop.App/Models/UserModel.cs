
namespace MyShop.Models
{
    public class UserModel
    {
        public int IdUser { get; set; }

        public string Name { get; set; } = null!;

        public string Address { get; set; } = null!;

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public string? UserType { get; set; }
    }
}
