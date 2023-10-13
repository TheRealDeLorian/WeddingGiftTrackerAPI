using System;
using System.Collections.Generic;

namespace WeddingGiftTrackerClassLibrary.Data;

public partial class GiftType
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Gift> Gifts { get; set; } = new List<Gift>();
}
