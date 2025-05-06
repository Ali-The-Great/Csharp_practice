using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class PlayerInOut
{
    public decimal MatchNo { get; set; }

    public decimal TeamId { get; set; }

    public decimal PlayerId { get; set; }

    public char InOut { get; set; }

    public decimal TimeInOut { get; set; }

    public string PlaySchedule { get; set; } = null!;

    public decimal PlayHalf { get; set; }

    public virtual MatchMast MatchNoNavigation { get; set; } = null!;

    public virtual PlayerMast Player { get; set; } = null!;

    public virtual SoccerCountry Team { get; set; } = null!;
}
