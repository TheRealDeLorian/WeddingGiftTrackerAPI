using System;
using System.Collections.Generic;

namespace WeddingGiftTrackerAPI.Data;

public partial class Jokecategory
{
    public int Id { get; set; }

    public string? Categoryname { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Categorizedjoke1> Categorizedjoke1s { get; set; } = new List<Categorizedjoke1>();
}
