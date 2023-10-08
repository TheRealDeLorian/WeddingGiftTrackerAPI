using System;
using System.Collections.Generic;

namespace WeddingGiftTrackerAPI.Data;

public partial class Guest
{
    public int Id { get; set; }

    public string? GuestName { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<GiftGuest> GiftGuests { get; set; } = new List<GiftGuest>();
}
