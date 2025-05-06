using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class PlayingPosition
{
    public string PositionId { get; set; } = null!;

    public string PositionDesc { get; set; } = null!;

    public virtual ICollection<PlayerMast> PlayerMasts { get; set; } = new List<PlayerMast>();
}
