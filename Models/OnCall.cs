using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class OnCall
{
    public int Nurse { get; set; }

    public int Blockfloor { get; set; }

    public int Blockcode { get; set; }

    public DateTime Oncallstart { get; set; }

    public DateTime Oncallend { get; set; }

    public virtual Block Block { get; set; } = null!;

    public virtual Nurse NurseNavigation { get; set; } = null!;
}
