using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class SoccerVenue
{
    public decimal VenueId { get; set; }

    public string VenueName { get; set; } = null!;

    public decimal CityId { get; set; }

    public decimal AudCapacity { get; set; }

    public virtual SoccerCity City { get; set; } = null!;

    public virtual ICollection<MatchMast> MatchMasts { get; set; } = new List<MatchMast>();
}
