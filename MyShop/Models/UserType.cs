using System;
using System.Collections.Generic;

namespace MyShop.Models;

public partial class UserType
{
    public int IdType { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
