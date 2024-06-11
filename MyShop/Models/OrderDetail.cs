using System;
using System.Collections.Generic;

namespace MyShop.Models;

public partial class OrderDetail
{
    public int IdDetail { get; set; }

    public int? IdOrder { get; set; }

    public int? IdProduct { get; set; }

    public int Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal Subtotal { get; set; }

    public virtual Order? IdOrderNavigation { get; set; }

    public virtual Product? IdProductNavigation { get; set; }
}
