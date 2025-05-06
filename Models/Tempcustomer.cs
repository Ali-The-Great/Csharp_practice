using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class Tempcustomer
{
    public decimal? CustomerId { get; set; }

    public string? CustName { get; set; }

    public string? City { get; set; }

    public decimal? Grade { get; set; }

    public decimal? SalesmanId { get; set; }
}
