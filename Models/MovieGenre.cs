using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class MovieGenre
{
    public int MovId { get; set; }

    public int GenId { get; set; }

    public virtual Genre Gen { get; set; } = null!;

    public virtual Movie Mov { get; set; } = null!;
}
