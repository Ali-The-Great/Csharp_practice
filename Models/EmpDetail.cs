using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class EmpDetail
{
    public int EmpIdno { get; set; }

    public string EmpFname { get; set; } = null!;

    public string EmpLname { get; set; } = null!;

    public int EmpDept { get; set; }

    public virtual EmpDepartment EmpDeptNavigation { get; set; } = null!;
}
