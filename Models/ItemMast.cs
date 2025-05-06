using System;
using System.Collections.Generic;

namespace revision.Models;

public partial class ItemMast
{
    public int ProId { get; set; }

    public string ProName { get; set; } = null!;

    public decimal ProPrice { get; set; }

    public int ProCom { get; set; }

    public virtual CompanyMast ProComNavigation { get; set; } = null!;
}
