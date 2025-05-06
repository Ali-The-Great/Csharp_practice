using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class Tempsalesman
{
    public decimal? SalesmanId { get; set; }

    public string? Name { get; set; }

    public string? City { get; set; }

    public decimal? Commission { get; set; }
}
