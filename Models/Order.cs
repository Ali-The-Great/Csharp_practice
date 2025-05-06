using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class Order
{
    public decimal OrdNo { get; set; }

    public decimal? PurchAmt { get; set; }

    public DateOnly? OrdDate { get; set; }

    public decimal CustomerId { get; set; }

    public decimal SalesmanId { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Salesman Salesman { get; set; } = null!;
}
