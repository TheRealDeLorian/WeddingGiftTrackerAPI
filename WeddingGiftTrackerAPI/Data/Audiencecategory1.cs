using System;
using System.Collections.Generic;

namespace WeddingGiftTrackerAPI.Data;

public partial class Audiencecategory1
{
    public int Id { get; set; }

    public string? Categoryname { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Categorizedaudience> Categorizedaudiences { get; set; } = new List<Categorizedaudience>();
}
