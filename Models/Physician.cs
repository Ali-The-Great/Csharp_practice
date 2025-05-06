﻿using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class Physician
{
    public int Employeeid { get; set; }

    public string Name { get; set; } = null!;

    public string Position { get; set; } = null!;

    public int Ssn { get; set; }

    public virtual ICollection<AffiliatedWith> AffiliatedWiths { get; set; } = new List<AffiliatedWith>();

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual ICollection<Department1> Department1s { get; set; } = new List<Department1>();

    public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();

    public virtual ICollection<Prescribe> Prescribes { get; set; } = new List<Prescribe>();

    public virtual ICollection<TrainedIn> TrainedIns { get; set; } = new List<TrainedIn>();

    public virtual ICollection<Undergo> Undergos { get; set; } = new List<Undergo>();
}
