using System;
using System.Collections.Generic;

namespace WeddingGiftTrackerAPI.Data;

public partial class Supply
{
    public string Supnr { get; set; } = null!;

    public string Prodnr { get; set; } = null!;

    public double? PurchasePrice { get; set; }

    /// <summary>
    /// DELIV_PERIOD IN DAYS
    /// </summary>
    public int? DelivPeriod { get; set; }

    public virtual Product ProdnrNavigation { get; set; } = null!;

    public virtual Supplier SupnrNavigation { get; set; } = null!;
}
