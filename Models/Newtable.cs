using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class Newtable
{
    public int? Roomnumber { get; set; }

    public string? Roomtype { get; set; }

    public int? Blockfloor { get; set; }

    public int? Blockcode { get; set; }

    public bool? Unavailable { get; set; }
}
