using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class Movie
{
    public int MovId { get; set; }

    public string? MovTitle { get; set; }

    public int? MovYear { get; set; }

    public int? MovTime { get; set; }

    public string? MovLang { get; set; }

    public DateOnly? MovDtRel { get; set; }

    public string? MovRelCountry { get; set; }
}
