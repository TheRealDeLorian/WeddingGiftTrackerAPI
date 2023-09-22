using System;
using System.Collections.Generic;

namespace WeddingGiftTrackerAPI.Data;

public partial class Joke
{
    public int Id { get; set; }

    public string? Jokename { get; set; }

    public string? Joketext { get; set; }

    public virtual ICollection<Categorizedjoke1> Categorizedjoke1s { get; set; } = new List<Categorizedjoke1>();

    public virtual ICollection<Deliveredjoke> Deliveredjokes { get; set; } = new List<Deliveredjoke>();
}
