using System;
using System.Collections.Generic;

namespace WeddingGiftTrackerAPI.Data;

public partial class PoLine
{
    public string Ponr { get; set; } = null!;

    public string Prodnr { get; set; } = null!;

    public int? Quantity { get; set; }

    public virtual PurchaseOrder PonrNavigation { get; set; } = null!;

    public virtual Product ProdnrNavigation { get; set; } = null!;
}
