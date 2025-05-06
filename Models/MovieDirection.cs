using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class MovieDirection
{
    public int DirId { get; set; }

    public int MovId { get; set; }

    public virtual Director Dir { get; set; } = null!;

    public virtual Movie Mov { get; set; } = null!;
}
