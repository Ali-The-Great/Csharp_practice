using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class Bh
{
    public string Name { get; set; } = null!;

    public int EmpId { get; set; }

    public string? Process { get; set; }
}
