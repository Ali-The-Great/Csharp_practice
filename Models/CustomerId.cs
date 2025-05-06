using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class CustomerId
{
    public decimal? OrdNo { get; set; }

    public decimal? PurchAmt { get; set; }

    public DateOnly? OrdDate { get; set; }

    public decimal? CustomerId1 { get; set; }

    public decimal? SalesmanId { get; set; }
}
