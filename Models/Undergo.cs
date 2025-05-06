using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class Undergo
{
    public int Patient { get; set; }

    public int Procedure { get; set; }

    public int Stay { get; set; }

    public DateTime Date { get; set; }

    public int Physician { get; set; }

    public int? Assistingnurse { get; set; }

    public virtual Nurse? AssistingnurseNavigation { get; set; }

    public virtual Patient PatientNavigation { get; set; } = null!;

    public virtual Physician PhysicianNavigation { get; set; } = null!;

    public virtual Procedure ProcedureNavigation { get; set; } = null!;

    public virtual Stay StayNavigation { get; set; } = null!;
}
