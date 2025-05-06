using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class PlayerMast
{
    public decimal PlayerId { get; set; }

    public decimal TeamId { get; set; }

    public decimal JerseyNo { get; set; }

    public string PlayerName { get; set; } = null!;

    public string PosiToPlay { get; set; } = null!;

    public DateOnly? DtOfBir { get; set; }

    public decimal? Age { get; set; }

    public string? PlayingClub { get; set; }

    public virtual ICollection<GoalDetail> GoalDetails { get; set; } = new List<GoalDetail>();

    public virtual ICollection<MatchMast> MatchMasts { get; set; } = new List<MatchMast>();

    public virtual ICollection<PenaltyShootout> PenaltyShootouts { get; set; } = new List<PenaltyShootout>();

    public virtual PlayingPosition PosiToPlayNavigation { get; set; } = null!;

    public virtual SoccerCountry Team { get; set; } = null!;
}
