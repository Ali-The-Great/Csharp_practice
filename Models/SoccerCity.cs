using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class SoccerCity
{
    public decimal CityId { get; set; }

    public string City { get; set; } = null!;

    public decimal CountryId { get; set; }

    public virtual SoccerCountry Country { get; set; } = null!;

    public virtual ICollection<SoccerVenue> SoccerVenues { get; set; } = new List<SoccerVenue>();
}
