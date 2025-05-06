using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class TrainedIn
{
    public int Physician { get; set; }

    public int Treatment { get; set; }

    public DateOnly Certificationdate { get; set; }

    public DateOnly Certificationexpires { get; set; }

    public virtual Physician PhysicianNavigation { get; set; } = null!;

    public virtual Procedure TreatmentNavigation { get; set; } = null!;
}
