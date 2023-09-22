using System;
using System.Collections.Generic;

namespace WeddingGiftTrackerAPI.Data;

public partial class Deliveredjoke1
{
    public int Id { get; set; }

    public DateOnly Delivereddate { get; set; }

    public int? Jokereactionid { get; set; }

    public int? Jokeid { get; set; }

    public int? Audienceid { get; set; }

    public string? Notes { get; set; }

    public virtual Audience? Audience { get; set; }

    public virtual Joke1? Joke { get; set; }

    public virtual Jokereactioncategory1? Jokereaction { get; set; }
}
