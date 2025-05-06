using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class SoccerCountry
{
    public decimal CountryId { get; set; }

    public string CountryAbbr { get; set; } = null!;

    public string CountryName { get; set; } = null!;

    public virtual ICollection<AsstRefereeMast> AsstRefereeMasts { get; set; } = new List<AsstRefereeMast>();

    public virtual ICollection<GoalDetail> GoalDetails { get; set; } = new List<GoalDetail>();

    public virtual ICollection<PenaltyShootout> PenaltyShootouts { get; set; } = new List<PenaltyShootout>();

    public virtual ICollection<PlayerMast> PlayerMasts { get; set; } = new List<PlayerMast>();

    public virtual ICollection<RefereeMast> RefereeMasts { get; set; } = new List<RefereeMast>();

    public virtual ICollection<SoccerCity> SoccerCities { get; set; } = new List<SoccerCity>();
}
