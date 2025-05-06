using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class Elephant
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateOnly? Date { get; set; }
}
