﻿using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class Person
{
    public int? Personid { get; set; }

    public string? Lastname { get; set; }

    public string? Firstname { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }
}
