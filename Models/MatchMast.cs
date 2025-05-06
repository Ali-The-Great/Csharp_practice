using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class MatchMast
{
    public decimal MatchNo { get; set; }

    public char PlayStage { get; set; }

    public DateOnly PlayDate { get; set; }

    public string Results { get; set; } = null!;

    public char DecidedBy { get; set; }

    public string GoalScore { get; set; } = null!;

    public decimal VenueId { get; set; }

    public decimal RefereeId { get; set; }

    public decimal Audence { get; set; }

    public decimal PlrOfMatch { get; set; }

    public decimal Stop1Sec { get; set; }

    public decimal Stop2Sec { get; set; }

    public virtual ICollection<GoalDetail> GoalDetails { get; set; } = new List<GoalDetail>();

    public virtual ICollection<PenaltyShootout> PenaltyShootouts { get; set; } = new List<PenaltyShootout>();

    public virtual PlayerMast PlrOfMatchNavigation { get; set; } = null!;

    public virtual RefereeMast Referee { get; set; } = null!;

    public virtual SoccerVenue Venue { get; set; } = null!;
}
