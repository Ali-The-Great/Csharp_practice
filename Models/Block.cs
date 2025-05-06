using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class Block
{
    public int Blockfloor { get; set; }

    public int Blockcode { get; set; }

    public virtual ICollection<OnCall> OnCalls { get; set; } = new List<OnCall>();

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}
