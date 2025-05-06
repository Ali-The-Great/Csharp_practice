using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class Department
{
    public decimal DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;

    public decimal? ManagerId { get; set; }

    public decimal? LocationId { get; set; }
}
