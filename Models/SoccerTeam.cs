using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class SoccerTeam
{
    public decimal TeamId { get; set; }

    public char TeamGroup { get; set; }

    public decimal MatchPlayed { get; set; }

    public decimal Won { get; set; }

    public decimal Draw { get; set; }

    public decimal Lost { get; set; }

    public decimal GoalFor { get; set; }

    public decimal GoalAgnst { get; set; }

    public decimal GoalDiff { get; set; }

    public decimal Points { get; set; }

    public decimal GroupPosition { get; set; }

    public virtual SoccerCountry Team { get; set; } = null!;
}
