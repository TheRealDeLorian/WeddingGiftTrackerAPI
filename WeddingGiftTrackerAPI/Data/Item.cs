using System;
using System.Collections.Generic;

namespace WeddingGiftTrackerAPI.Data;

public partial class Item
{
    public int Id { get; set; }

    public string? Itemname { get; set; }

    public decimal? Price { get; set; }

    public int? Itemtype { get; set; }

    public int? Popularitytype { get; set; }

    public DateOnly? Datepurchased { get; set; }

    public int? Qty { get; set; }

    public virtual ICollection<Datepurchased> Datepurchaseds { get; set; } = new List<Datepurchased>();

    public virtual Itemtype? ItemtypeNavigation { get; set; }

    public virtual Popularitytype? PopularitytypeNavigation { get; set; }
}
