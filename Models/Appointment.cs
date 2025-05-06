using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class Appointment
{
    public int Appointmentid { get; set; }

    public int Patient { get; set; }

    public int? Prepnurse { get; set; }

    public int Physician { get; set; }

    public DateTime StartDtTime { get; set; }

    public DateTime EndDtTime { get; set; }

    public string Examinationroom { get; set; } = null!;

    public virtual Patient PatientNavigation { get; set; } = null!;

    public virtual Physician PhysicianNavigation { get; set; } = null!;

    public virtual Nurse? PrepnurseNavigation { get; set; }

    public virtual ICollection<Prescribe> Prescribes { get; set; } = new List<Prescribe>();
}
