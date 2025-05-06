using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class Sybba
{
    public decimal OrdNum { get; set; }

    public decimal? OrdAmount { get; set; }

    public DateOnly OrdDate { get; set; }

    public string CustCode { get; set; } = null!;

    public string AgentCode { get; set; } = null!;
}
