using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class PenaltyShootout
{
    public decimal KickId { get; set; }

    public decimal MatchNo { get; set; }

    public decimal TeamId { get; set; }

    public decimal PlayerId { get; set; }

    public char ScoreGoal { get; set; }

    public decimal KickNo { get; set; }

    public virtual MatchMast MatchNoNavigation { get; set; } = null!;

    public virtual PlayerMast Player { get; set; } = null!;

    public virtual SoccerCountry Team { get; set; } = null!;
}
