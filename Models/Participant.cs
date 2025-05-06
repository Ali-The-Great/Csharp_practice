using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class Participant
{
    public int ParticipantId { get; set; }

    public string PartName { get; set; } = null!;
}
