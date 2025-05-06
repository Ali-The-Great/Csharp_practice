using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class TeamCoach
{
    public decimal TeamId { get; set; }

    public decimal CoachId { get; set; }

    public virtual CoachMast Coach { get; set; } = null!;

    public virtual SoccerCountry Team { get; set; } = null!;
}
