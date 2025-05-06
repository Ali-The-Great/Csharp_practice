using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class Salesman
{
    public decimal SalesmanId { get; set; }

    public string Name { get; set; } = null!;

    public string? City { get; set; }

    public decimal? Commission { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
