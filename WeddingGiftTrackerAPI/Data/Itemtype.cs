using System;
using System.Collections.Generic;

namespace WeddingGiftTrackerAPI.Data;

public partial class Itemtype
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();
}
