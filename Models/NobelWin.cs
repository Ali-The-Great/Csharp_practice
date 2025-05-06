using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class NobelWin
{
    public int? Year { get; set; }

    public string? Subject { get; set; }

    public string? Winner { get; set; }

    public string? Country { get; set; }

    public string? Category { get; set; }
}
