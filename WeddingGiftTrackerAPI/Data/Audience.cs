using System;
using System.Collections.Generic;

namespace WeddingGiftTrackerAPI.Data;

public partial class Audience
{
    public int Id { get; set; }

    public string? Audiencename { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Categorizedaudience> Categorizedaudiences { get; set; } = new List<Categorizedaudience>();

    public virtual ICollection<Deliveredjoke1> Deliveredjoke1s { get; set; } = new List<Deliveredjoke1>();
}
