using System;
using System.Collections.Generic;

namespace WeddingGiftTrackerAPI.Data;

public partial class PurchaseOrder
{
    public string Ponr { get; set; } = null!;

    public DateOnly? Podate { get; set; }

    public string Supnr { get; set; } = null!;

    public virtual ICollection<PoLine> PoLines { get; set; } = new List<PoLine>();

    public virtual Supplier SupnrNavigation { get; set; } = null!;
}
