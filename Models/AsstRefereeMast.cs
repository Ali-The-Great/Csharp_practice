using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class AsstRefereeMast
{
    public decimal AssRefId { get; set; }

    public string AssRefName { get; set; } = null!;

    public decimal CountryId { get; set; }

    public virtual SoccerCountry Country { get; set; } = null!;
}
