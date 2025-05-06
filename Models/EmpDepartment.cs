using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class EmpDepartment
{
    public int DptCode { get; set; }

    public string DptName { get; set; } = null!;

    public int DptAllotment { get; set; }

    public virtual ICollection<EmpDetail> EmpDetails { get; set; } = new List<EmpDetail>();
}
