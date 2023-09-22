using System;
using System.Collections.Generic;

namespace WeddingGiftTrackerAPI.Data;

public partial class Jokecategory1
{
    public int Id { get; set; }

    public string? Categoryname { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Categorizedjoke> Categorizedjokes { get; set; } = new List<Categorizedjoke>();
}
