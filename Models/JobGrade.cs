using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class JobGrade
{
    public string GradeLevel { get; set; } = null!;

    public decimal LowestSal { get; set; }

    public decimal HighestSal { get; set; }
}
