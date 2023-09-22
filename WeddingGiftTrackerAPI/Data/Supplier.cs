using System;
using System.Collections.Generic;

namespace WeddingGiftTrackerAPI.Data;

public partial class Supplier
{
    public string Supnr { get; set; } = null!;

    public string Supname { get; set; } = null!;

    public string? Supaddress { get; set; }

    public string? Supcity { get; set; }

    public short? Supstatus { get; set; }

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<Supply> Supplies { get; set; } = new List<Supply>();
}
