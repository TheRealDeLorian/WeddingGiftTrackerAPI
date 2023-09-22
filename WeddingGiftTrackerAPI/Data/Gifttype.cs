using System;
using System.Collections.Generic;

namespace WeddingGiftTrackerAPI.Data;

public partial class Gifttype
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Gift> Gifts { get; set; } = new List<Gift>();
}
