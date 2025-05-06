using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class RefereeMast
{
    public decimal RefereeId { get; set; }

    public string RefereeName { get; set; } = null!;

    public decimal CountryId { get; set; }

    public virtual SoccerCountry Country { get; set; } = null!;

    public virtual ICollection<MatchMast> MatchMasts { get; set; } = new List<MatchMast>();
}
