using System;
using System.Collections.Generic;

namespace WeddingGiftTrackerAPI.Data;

public partial class Categorizedjoke
{
    public int Id { get; set; }

    public int? Jokeid { get; set; }

    public int? Jokecategoryid { get; set; }

    public virtual Joke1? Joke { get; set; }

    public virtual Jokecategory1? Jokecategory { get; set; }
}
