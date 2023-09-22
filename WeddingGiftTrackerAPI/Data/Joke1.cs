using System;
using System.Collections.Generic;

namespace WeddingGiftTrackerAPI.Data;

public partial class Joke1
{
    public int Id { get; set; }

    public string? Jokename { get; set; }

    public string? Joketext { get; set; }

    public virtual ICollection<Categorizedjoke> Categorizedjokes { get; set; } = new List<Categorizedjoke>();

    public virtual ICollection<Deliveredjoke1> Deliveredjoke1s { get; set; } = new List<Deliveredjoke1>();
}
