using System;
using System.Collections.Generic;

namespace WeddingGiftTrackerAPI.Data;

public partial class Jokereactioncategory1
{
    public int Id { get; set; }

    public string? Reactionlevel { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Deliveredjoke1> Deliveredjoke1s { get; set; } = new List<Deliveredjoke1>();
}
