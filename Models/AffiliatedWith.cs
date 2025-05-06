using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class AffiliatedWith
{
    public int Physician { get; set; }

    public int Department { get; set; }

    public bool Primaryaffiliation { get; set; }

    public virtual Department1 DepartmentNavigation { get; set; } = null!;

    public virtual Physician PhysicianNavigation { get; set; } = null!;
}
