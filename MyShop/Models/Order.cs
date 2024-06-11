using System;
using System.Collections.Generic;

namespace MyShop.Models;

public partial class Order
{
    public int IdOrder { get; set; }

    public int? IdUser { get; set; }

    public decimal Total { get; set; }

    public DateTime Date { get; set; }

    public virtual User? IdUserNavigation { get; set; }

    public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
