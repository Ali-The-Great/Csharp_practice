using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class Customer
{
    public decimal CustomerId { get; set; }

    public string CustName { get; set; } = null!;

    public string? City { get; set; }

    public decimal? Grade { get; set; }

    public decimal SalesmanId { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual Salesman Salesman { get; set; } = null!;
}
