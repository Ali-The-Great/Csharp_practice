using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class PlayerBooked
{
    public decimal MatchNo { get; set; }

    public decimal TeamId { get; set; }

    public decimal PlayerId { get; set; }

    public decimal BookingTime { get; set; }

    public char? SentOff { get; set; }

    public string PlaySchedule { get; set; } = null!;

    public decimal PlayHalf { get; set; }

    public virtual MatchMast MatchNoNavigation { get; set; } = null!;

    public virtual PlayerMast Player { get; set; } = null!;

    public virtual SoccerCountry Team { get; set; } = null!;
}
