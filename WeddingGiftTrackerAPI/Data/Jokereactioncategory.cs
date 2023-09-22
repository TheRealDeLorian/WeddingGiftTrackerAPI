using System;
using System.Collections.Generic;

namespace WeddingGiftTrackerAPI.Data;

public partial class Jokereactioncategory
{
    public int Id { get; set; }

    public string? Reactionlevel { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Deliveredjoke> Deliveredjokes { get; set; } = new List<Deliveredjoke>();
}
