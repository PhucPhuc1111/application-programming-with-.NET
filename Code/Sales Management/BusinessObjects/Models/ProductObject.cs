using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class ProductObject
{
    public int ProductId { get; set; }

    public int CategoryId { get; set; }

    public string ProductName { get; set; } = null!;

    public string Weight { get; set; } = null!;

    public decimal UnitPrice { get; set; }

    public int UnitsInStock { get; set; }

    public virtual ICollection<OrderDetailObject> OrderDetails { get; set; } = new List<OrderDetailObject>();
}
