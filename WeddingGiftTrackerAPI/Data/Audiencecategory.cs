using System;
using System.Collections.Generic;

namespace WeddingGiftTrackerAPI.Data;

public partial class Audiencecategory
{
    public int Id { get; set; }

    public string? Categoryname { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Categorizedaudience1> Categorizedaudience1s { get; set; } = new List<Categorizedaudience1>();
}
