using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class Room
{
    public int Roomnumber { get; set; }

    public string Roomtype { get; set; } = null!;

    public int Blockfloor { get; set; }

    public int Blockcode { get; set; }

    public bool Unavailable { get; set; }

    public virtual Block Block { get; set; } = null!;

    public virtual ICollection<Stay> Stays { get; set; } = new List<Stay>();
}
