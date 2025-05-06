using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class Zebra
{
    public int Id { get; set; }

    public int? Score { get; set; }

    public DateOnly? Date { get; set; }
}
