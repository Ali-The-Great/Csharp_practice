﻿using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class Location
{
    public decimal LocationId { get; set; }

    public string? StreetAddress { get; set; }

    public string? PostalCode { get; set; }

    public string City { get; set; } = null!;

    public string? StateProvince { get; set; }

    public string? CountryId { get; set; }
}
