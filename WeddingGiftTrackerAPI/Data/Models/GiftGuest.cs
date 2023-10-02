﻿using System;
using System.Collections.Generic;

namespace WeddingGiftTrackerAPI.Data.Models;

public partial class GiftGuest
{
    public int Id { get; set; }

    public int? GiftId { get; set; }

    public int? GuestId { get; set; }

    public virtual Gift? Gift { get; set; }

    public virtual Guest? Guest { get; set; }
}
