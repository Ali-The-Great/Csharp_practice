using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class Newtab
{
    public decimal? OrdNo { get; set; }

    public decimal? PurchAmt { get; set; }

    public DateOnly? OrdDate { get; set; }

    public decimal? CustomerId { get; set; }

    public decimal? SalesmanId { get; set; }
}
