using System;
using System.Collections.Generic;

namespace WeddingGiftTrackerAPI.Data;

public partial class Deliveredjoke
{
    public int Id { get; set; }

    public DateOnly Delivereddate { get; set; }

    public int? Jokereactionid { get; set; }

    public int? Jokeid { get; set; }

    public int? Audienceid { get; set; }

    public string? Notes { get; set; }

    public virtual Audience1? Audience { get; set; }

    public virtual Joke? Joke { get; set; }

    public virtual Jokereactioncategory? Jokereaction { get; set; }
}
