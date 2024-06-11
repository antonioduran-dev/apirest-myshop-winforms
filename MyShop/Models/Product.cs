using System;
using System.Collections.Generic;

namespace MyShop.Models;

public partial class Product
{
    public int IdProduct { get; set; }

    public int? IdCategory { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int Stock { get; set; }

    public virtual Category? IdCategoryNavigation { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
