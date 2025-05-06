using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class MatchCaptain
{
    public decimal MatchNo { get; set; }

    public decimal TeamId { get; set; }

    public decimal PlayerCaptain { get; set; }

    public virtual MatchMast MatchNoNavigation { get; set; } = null!;

    public virtual PlayerMast PlayerCaptainNavigation { get; set; } = null!;

    public virtual SoccerCountry Team { get; set; } = null!;
}
