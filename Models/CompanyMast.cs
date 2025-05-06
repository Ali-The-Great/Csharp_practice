using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class CompanyMast
{
    public int ComId { get; set; }

    public string ComName { get; set; } = null!;

    public virtual ICollection<ItemMast> ItemMasts { get; set; } = new List<ItemMast>();
}
