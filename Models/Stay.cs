using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class Stay
{
    public int Stayid { get; set; }

    public int Patient { get; set; }

    public int Room { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public virtual Patient PatientNavigation { get; set; } = null!;

    public virtual Room RoomNavigation { get; set; } = null!;

    public virtual ICollection<Undergo> Undergos { get; set; } = new List<Undergo>();
}
