using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class OrderDetailObject
{
    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public decimal UnitPrice { get; set; }

    public int Quantity { get; set; }

    public double Discount { get; set; }

    public virtual OrderObject Order { get; set; } = null!;

    public virtual ProductObject Product { get; set; } = null!;
}
