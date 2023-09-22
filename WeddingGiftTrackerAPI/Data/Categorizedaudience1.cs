using System;
using System.Collections.Generic;

namespace WeddingGiftTrackerAPI.Data;

public partial class Categorizedaudience1
{
    public int Id { get; set; }

    public int? Audienceid { get; set; }

    public int? Audiencecategoryid { get; set; }

    public virtual Audience1? Audience { get; set; }

    public virtual Audiencecategory? Audiencecategory { get; set; }
}
