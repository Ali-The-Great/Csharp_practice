using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class MatchDetail
{
    public decimal MatchNo { get; set; }

    public char PlayStage { get; set; }

    public decimal TeamId { get; set; }

    public char WinLose { get; set; }

    public char DecidedBy { get; set; }

    public decimal GoalScore { get; set; }

    public decimal? PenaltyScore { get; set; }

    public decimal AssRef { get; set; }

    public decimal PlayerGk { get; set; }

    public virtual AsstRefereeMast AssRefNavigation { get; set; } = null!;

    public virtual MatchMast MatchNoNavigation { get; set; } = null!;

    public virtual PlayerMast PlayerGkNavigation { get; set; } = null!;

    public virtual SoccerCountry Team { get; set; } = null!;
}
