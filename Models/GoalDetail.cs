using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class GoalDetail
{
    public decimal GoalId { get; set; }

    public decimal MatchNo { get; set; }

    public decimal PlayerId { get; set; }

    public decimal TeamId { get; set; }

    public decimal GoalTime { get; set; }

    public char GoalType { get; set; }

    public char PlayStage { get; set; }

    public string GoalSchedule { get; set; } = null!;

    public decimal? GoalHalf { get; set; }

    public virtual MatchMast MatchNoNavigation { get; set; } = null!;

    public virtual PlayerMast Player { get; set; } = null!;

    public virtual SoccerCountry Team { get; set; } = null!;
}
