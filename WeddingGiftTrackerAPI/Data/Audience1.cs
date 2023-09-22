using System;
using System.Collections.Generic;

namespace WeddingGiftTrackerAPI.Data;

public partial class Audience1
{
    public int Id { get; set; }

    public string? Audiencename { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Categorizedaudience1> Categorizedaudience1s { get; set; } = new List<Categorizedaudience1>();

    public virtual ICollection<Deliveredjoke> Deliveredjokes { get; set; } = new List<Deliveredjoke>();
}
