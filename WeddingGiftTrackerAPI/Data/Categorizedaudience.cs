using System;
using System.Collections.Generic;

namespace WeddingGiftTrackerAPI.Data;

public partial class Categorizedaudience
{
    public int Id { get; set; }

    public int? Audienceid { get; set; }

    public int? Audiencecategoryid { get; set; }

    public virtual Audience? Audience { get; set; }

    public virtual Audiencecategory1? Audiencecategory { get; set; }
}
