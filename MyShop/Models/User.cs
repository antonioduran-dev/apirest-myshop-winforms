using System;
using System.Collections.Generic;

namespace MyShop.Models;

public partial class User
{
    public int IdUser { get; set; }

    public int? IdType { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public virtual UserType? IdTypeNavigation { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
