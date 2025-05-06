using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class Casino
{
    public decimal Pricerange { get; set; }

    public string? Events { get; set; }

    public string Location { get; set; } = null!;

    public string Casino1 { get; set; } = null!;
}
