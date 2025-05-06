using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class GameScore
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Score { get; set; }
}
