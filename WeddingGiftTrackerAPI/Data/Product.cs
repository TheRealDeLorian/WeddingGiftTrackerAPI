using System;
using System.Collections.Generic;

namespace WeddingGiftTrackerAPI.Data;

public partial class Product
{
    public string Prodnr { get; set; } = null!;

    public string Prodname { get; set; } = null!;

    public string? Prodtype { get; set; }

    public int? AvailableQuantity { get; set; }

    public virtual ICollection<PoLine> PoLines { get; set; } = new List<PoLine>();

    public virtual ICollection<Supply> Supplies { get; set; } = new List<Supply>();
}
