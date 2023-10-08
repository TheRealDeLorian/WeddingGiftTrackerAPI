using System;
using System.Collections.Generic;

namespace WeddingGiftTrackerAPI.Data;

public partial class Gift
{
    public int Id { get; set; }

    public string? GiftName { get; set; }

    public string? Description { get; set; }

    public int? GiftType { get; set; }

    public virtual ICollection<GiftGuest> GiftGuests { get; set; } = new List<GiftGuest>();

    public virtual GiftType? GiftTypeNavigation { get; set; }
}
