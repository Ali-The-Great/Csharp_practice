using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class JobHistory
{
    public decimal EmployeeId { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public string JobId { get; set; } = null!;

    public decimal? DepartmentId { get; set; }
}
