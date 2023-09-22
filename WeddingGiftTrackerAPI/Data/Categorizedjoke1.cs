using System;
using System.Collections.Generic;

namespace WeddingGiftTrackerAPI.Data;

public partial class Categorizedjoke1
{
    public int Id { get; set; }

    public int? Jokeid { get; set; }

    public int? Jokecategoryid { get; set; }

    public virtual Joke? Joke { get; set; }

    public virtual Jokecategory? Jokecategory { get; set; }
}
