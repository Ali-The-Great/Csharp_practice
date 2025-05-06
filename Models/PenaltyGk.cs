using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class PenaltyGk
{
    public decimal MatchNo { get; set; }

    public decimal TeamId { get; set; }

    public decimal PlayerGk { get; set; }

    public virtual MatchMast MatchNoNavigation { get; set; } = null!;

    public virtual PlayerMast PlayerGkNavigation { get; set; } = null!;

    public virtual SoccerCountry Team { get; set; } = null!;
}
