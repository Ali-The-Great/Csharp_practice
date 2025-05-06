using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class Rating
{
    public int MovId { get; set; }

    public int RevId { get; set; }

    public decimal? RevStars { get; set; }

    public int? NumORatings { get; set; }

    public virtual Movie Mov { get; set; } = null!;

    public virtual Reviewer Rev { get; set; } = null!;
}
