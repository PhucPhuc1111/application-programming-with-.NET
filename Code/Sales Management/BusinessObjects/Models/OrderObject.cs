using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class OrderObject
{
    public int OrderId { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime? RequiredDate { get; set; }

    public DateTime? ShippedDate { get; set; }

    public decimal? Freight { get; set; }

    public int MemberId { get; set; }

    public virtual MemberObject Member { get; set; } = null!;

    public virtual ICollection<OrderDetailObject> OrderDetails { get; set; } = new List<OrderDetailObject>();
}
