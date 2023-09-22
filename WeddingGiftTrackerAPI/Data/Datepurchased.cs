using System;
using System.Collections.Generic;

namespace WeddingGiftTrackerAPI.Data;

public partial class Datepurchased
{
    public int Id { get; set; }

    public int? Itemid { get; set; }

    public DateOnly? Purchaseday { get; set; }

    public virtual Item? Item { get; set; }
}
