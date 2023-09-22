using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WeddingGiftTrackerAPI.Data;

public partial class WeddingGiftDbContext : DbContext
{
    public WeddingGiftDbContext()
    {
    }

    public WeddingGiftDbContext(DbContextOptions<WeddingGiftDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Audience> Audiences { get; set; }

    public virtual DbSet<Audience1> Audiences1 { get; set; }

    public virtual DbSet<Audiencecategory> Audiencecategories { get; set; }

    public virtual DbSet<Audiencecategory1> Audiencecategories1 { get; set; }

    public virtual DbSet<Categorizedaudience> Categorizedaudiences { get; set; }

    public virtual DbSet<Categorizedaudience1> Categorizedaudiences1 { get; set; }

    public virtual DbSet<Categorizedjoke> Categorizedjokes { get; set; }

    public virtual DbSet<Categorizedjoke1> Categorizedjokes1 { get; set; }

    public virtual DbSet<Datepurchased> Datepurchaseds { get; set; }

    public virtual DbSet<Deliveredjoke> Deliveredjokes { get; set; }

    public virtual DbSet<Deliveredjoke1> Deliveredjokes1 { get; set; }

    public virtual DbSet<Gift> Gifts { get; set; }

    public virtual DbSet<GiftGuest> GiftGuests { get; set; }

    public virtual DbSet<Gifttype> Gifttypes { get; set; }

    public virtual DbSet<Guest> Guests { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<Itemtype> Itemtypes { get; set; }

    public virtual DbSet<Joke> Jokes { get; set; }

    public virtual DbSet<Joke1> Jokes1 { get; set; }

    public virtual DbSet<Jokecategory> Jokecategories { get; set; }

    public virtual DbSet<Jokecategory1> Jokecategories1 { get; set; }

    public virtual DbSet<Jokereactioncategory> Jokereactioncategories { get; set; }

    public virtual DbSet<Jokereactioncategory1> Jokereactioncategories1 { get; set; }

    public virtual DbSet<PoLine> PoLines { get; set; }

    public virtual DbSet<Popularitytype> Popularitytypes { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<Supply> Supplies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("name=DbConnectionString");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Audience>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("audience_pkey");

            entity.ToTable("audience", "dadabaseTest");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Audiencename)
                .HasMaxLength(300)
                .HasColumnName("audiencename");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasColumnName("description");
        });

        modelBuilder.Entity<Audience1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("audience_pkey");

            entity.ToTable("audience", "dadabase");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Audiencename)
                .HasMaxLength(300)
                .HasColumnName("audiencename");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasColumnName("description");
        });

        modelBuilder.Entity<Audiencecategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("audiencecategory_pkey");

            entity.ToTable("audiencecategory", "dadabase");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Categoryname)
                .HasMaxLength(200)
                .HasColumnName("categoryname");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasColumnName("description");
        });

        modelBuilder.Entity<Audiencecategory1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("audiencecategory_pkey");

            entity.ToTable("audiencecategory", "dadabaseTest");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Categoryname)
                .HasMaxLength(200)
                .HasColumnName("categoryname");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasColumnName("description");
        });

        modelBuilder.Entity<Categorizedaudience>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("categorizedaudience_pkey");

            entity.ToTable("categorizedaudience", "dadabaseTest");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Audiencecategoryid).HasColumnName("audiencecategoryid");
            entity.Property(e => e.Audienceid).HasColumnName("audienceid");

            entity.HasOne(d => d.Audiencecategory).WithMany(p => p.Categorizedaudiences)
                .HasForeignKey(d => d.Audiencecategoryid)
                .HasConstraintName("categorizedaudience_audiencecategoryid_fkey");

            entity.HasOne(d => d.Audience).WithMany(p => p.Categorizedaudiences)
                .HasForeignKey(d => d.Audienceid)
                .HasConstraintName("categorizedaudience_audienceid_fkey");
        });

        modelBuilder.Entity<Categorizedaudience1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("categorizedaudience_pkey");

            entity.ToTable("categorizedaudience", "dadabase");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Audiencecategoryid).HasColumnName("audiencecategoryid");
            entity.Property(e => e.Audienceid).HasColumnName("audienceid");

            entity.HasOne(d => d.Audiencecategory).WithMany(p => p.Categorizedaudience1s)
                .HasForeignKey(d => d.Audiencecategoryid)
                .HasConstraintName("categorizedaudience_audiencecategoryid_fkey");

            entity.HasOne(d => d.Audience).WithMany(p => p.Categorizedaudience1s)
                .HasForeignKey(d => d.Audienceid)
                .HasConstraintName("categorizedaudience_audienceid_fkey");
        });

        modelBuilder.Entity<Categorizedjoke>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("categorizedjoke_pkey");

            entity.ToTable("categorizedjoke", "dadabaseTest");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Jokecategoryid).HasColumnName("jokecategoryid");
            entity.Property(e => e.Jokeid).HasColumnName("jokeid");

            entity.HasOne(d => d.Jokecategory).WithMany(p => p.Categorizedjokes)
                .HasForeignKey(d => d.Jokecategoryid)
                .HasConstraintName("categorizedjoke_jokecategoryid_fkey");

            entity.HasOne(d => d.Joke).WithMany(p => p.Categorizedjokes)
                .HasForeignKey(d => d.Jokeid)
                .HasConstraintName("categorizedjoke_jokeid_fkey");
        });

        modelBuilder.Entity<Categorizedjoke1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("categorizedjoke_pkey");

            entity.ToTable("categorizedjoke", "dadabase");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Jokecategoryid).HasColumnName("jokecategoryid");
            entity.Property(e => e.Jokeid).HasColumnName("jokeid");

            entity.HasOne(d => d.Jokecategory).WithMany(p => p.Categorizedjoke1s)
                .HasForeignKey(d => d.Jokecategoryid)
                .HasConstraintName("categorizedjoke_jokecategoryid_fkey");

            entity.HasOne(d => d.Joke).WithMany(p => p.Categorizedjoke1s)
                .HasForeignKey(d => d.Jokeid)
                .HasConstraintName("categorizedjoke_jokeid_fkey");
        });

        modelBuilder.Entity<Datepurchased>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("datepurchased_pkey");

            entity.ToTable("datepurchased", "wendys");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.Purchaseday).HasColumnName("purchaseday");

            entity.HasOne(d => d.Item).WithMany(p => p.Datepurchaseds)
                .HasForeignKey(d => d.Itemid)
                .HasConstraintName("datepurchased_itemid_fkey");
        });

        modelBuilder.Entity<Deliveredjoke>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("deliveredjoke_pkey");

            entity.ToTable("deliveredjoke", "dadabase");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Audienceid).HasColumnName("audienceid");
            entity.Property(e => e.Delivereddate).HasColumnName("delivereddate");
            entity.Property(e => e.Jokeid).HasColumnName("jokeid");
            entity.Property(e => e.Jokereactionid).HasColumnName("jokereactionid");
            entity.Property(e => e.Notes)
                .HasMaxLength(1000)
                .HasColumnName("notes");

            entity.HasOne(d => d.Audience).WithMany(p => p.Deliveredjokes)
                .HasForeignKey(d => d.Audienceid)
                .HasConstraintName("deliveredjoke_audienceid_fkey");

            entity.HasOne(d => d.Joke).WithMany(p => p.Deliveredjokes)
                .HasForeignKey(d => d.Jokeid)
                .HasConstraintName("deliveredjoke_jokeid_fkey");

            entity.HasOne(d => d.Jokereaction).WithMany(p => p.Deliveredjokes)
                .HasForeignKey(d => d.Jokereactionid)
                .HasConstraintName("deliveredjoke_jokereactionid_fkey");
        });

        modelBuilder.Entity<Deliveredjoke1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("deliveredjoke_pkey");

            entity.ToTable("deliveredjoke", "dadabaseTest");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Audienceid).HasColumnName("audienceid");
            entity.Property(e => e.Delivereddate).HasColumnName("delivereddate");
            entity.Property(e => e.Jokeid).HasColumnName("jokeid");
            entity.Property(e => e.Jokereactionid).HasColumnName("jokereactionid");
            entity.Property(e => e.Notes)
                .HasMaxLength(1000)
                .HasColumnName("notes");

            entity.HasOne(d => d.Audience).WithMany(p => p.Deliveredjoke1s)
                .HasForeignKey(d => d.Audienceid)
                .HasConstraintName("deliveredjoke_audienceid_fkey");

            entity.HasOne(d => d.Joke).WithMany(p => p.Deliveredjoke1s)
                .HasForeignKey(d => d.Jokeid)
                .HasConstraintName("deliveredjoke_jokeid_fkey");

            entity.HasOne(d => d.Jokereaction).WithMany(p => p.Deliveredjoke1s)
                .HasForeignKey(d => d.Jokereactionid)
                .HasConstraintName("deliveredjoke_jokereactionid_fkey");
        });

        modelBuilder.Entity<Gift>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gift_pkey");

            entity.ToTable("gift", "weddinggifttracker");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasColumnName("description");
            entity.Property(e => e.Giftname)
                .HasMaxLength(100)
                .HasColumnName("giftname");
            entity.Property(e => e.Gifttype).HasColumnName("gifttype");

            entity.HasOne(d => d.GifttypeNavigation).WithMany(p => p.Gifts)
                .HasForeignKey(d => d.Gifttype)
                .HasConstraintName("gift_gifttype_fkey");
        });

        modelBuilder.Entity<GiftGuest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gift_guest_pkey");

            entity.ToTable("gift_guest", "weddinggifttracker");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Giftid).HasColumnName("giftid");
            entity.Property(e => e.Guestid).HasColumnName("guestid");

            entity.HasOne(d => d.Gift).WithMany(p => p.GiftGuests)
                .HasForeignKey(d => d.Giftid)
                .HasConstraintName("gift_guest_giftid_fkey");

            entity.HasOne(d => d.Guest).WithMany(p => p.GiftGuests)
                .HasForeignKey(d => d.Guestid)
                .HasConstraintName("gift_guest_guestid_fkey");
        });

        modelBuilder.Entity<Gifttype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gifttype_pkey");

            entity.ToTable("gifttype", "weddinggifttracker");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasColumnName("description");
        });

        modelBuilder.Entity<Guest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("guest_pkey");

            entity.ToTable("guest", "weddinggifttracker");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(3000)
                .HasColumnName("address");
            entity.Property(e => e.Guestname)
                .HasMaxLength(1000)
                .HasColumnName("guestname");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("item_pkey");

            entity.ToTable("item", "wendys");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Datepurchased).HasColumnName("datepurchased");
            entity.Property(e => e.Itemname)
                .HasMaxLength(1000)
                .HasColumnName("itemname");
            entity.Property(e => e.Itemtype).HasColumnName("itemtype");
            entity.Property(e => e.Popularitytype).HasColumnName("popularitytype");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Qty).HasColumnName("qty");

            entity.HasOne(d => d.ItemtypeNavigation).WithMany(p => p.Items)
                .HasForeignKey(d => d.Itemtype)
                .HasConstraintName("item_itemtype_fkey");

            entity.HasOne(d => d.PopularitytypeNavigation).WithMany(p => p.Items)
                .HasForeignKey(d => d.Popularitytype)
                .HasConstraintName("item_popularitytype_fkey");
        });

        modelBuilder.Entity<Itemtype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("itemtype_pkey");

            entity.ToTable("itemtype", "wendys");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasColumnName("description");
        });

        modelBuilder.Entity<Joke>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("joke_pkey");

            entity.ToTable("joke", "dadabase");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Jokename)
                .HasMaxLength(200)
                .HasColumnName("jokename");
            entity.Property(e => e.Joketext)
                .HasMaxLength(1000)
                .HasColumnName("joketext");
        });

        modelBuilder.Entity<Joke1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("joke_pkey");

            entity.ToTable("joke", "dadabaseTest");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Jokename)
                .HasMaxLength(200)
                .HasColumnName("jokename");
            entity.Property(e => e.Joketext)
                .HasMaxLength(1000)
                .HasColumnName("joketext");
        });

        modelBuilder.Entity<Jokecategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("jokecategory_pkey");

            entity.ToTable("jokecategory", "dadabase");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Categoryname)
                .HasMaxLength(200)
                .HasColumnName("categoryname");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasColumnName("description");
        });

        modelBuilder.Entity<Jokecategory1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("jokecategory_pkey");

            entity.ToTable("jokecategory", "dadabaseTest");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Categoryname)
                .HasMaxLength(200)
                .HasColumnName("categoryname");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasColumnName("description");
        });

        modelBuilder.Entity<Jokereactioncategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("jokereactioncategory_pkey");

            entity.ToTable("jokereactioncategory", "dadabase");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasColumnName("description");
            entity.Property(e => e.Reactionlevel)
                .HasMaxLength(200)
                .HasColumnName("reactionlevel");
        });

        modelBuilder.Entity<Jokereactioncategory1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("jokereactioncategory_pkey");

            entity.ToTable("jokereactioncategory", "dadabaseTest");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasColumnName("description");
            entity.Property(e => e.Reactionlevel)
                .HasMaxLength(200)
                .HasColumnName("reactionlevel");
        });

        modelBuilder.Entity<PoLine>(entity =>
        {
            entity.HasKey(e => new { e.Ponr, e.Prodnr }).HasName("po_line_pkey");

            entity.ToTable("po_line");

            entity.Property(e => e.Ponr)
                .HasMaxLength(7)
                .IsFixedLength()
                .HasColumnName("ponr");
            entity.Property(e => e.Prodnr)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("prodnr");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.PonrNavigation).WithMany(p => p.PoLines)
                .HasForeignKey(d => d.Ponr)
                .HasConstraintName("po_line_ponr_fkey");

            entity.HasOne(d => d.ProdnrNavigation).WithMany(p => p.PoLines)
                .HasForeignKey(d => d.Prodnr)
                .HasConstraintName("po_line_prodnr_fkey");
        });

        modelBuilder.Entity<Popularitytype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("popularitytype_pkey");

            entity.ToTable("popularitytype", "wendys");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasColumnName("description");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Prodnr).HasName("product_pkey");

            entity.ToTable("product");

            entity.HasIndex(e => e.Prodname, "uc1").IsUnique();

            entity.Property(e => e.Prodnr)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("prodnr");
            entity.Property(e => e.AvailableQuantity).HasColumnName("available_quantity");
            entity.Property(e => e.Prodname)
                .HasMaxLength(60)
                .HasColumnName("prodname");
            entity.Property(e => e.Prodtype)
                .HasMaxLength(10)
                .HasColumnName("prodtype");
        });

        modelBuilder.Entity<PurchaseOrder>(entity =>
        {
            entity.HasKey(e => e.Ponr).HasName("purchase_order_pkey");

            entity.ToTable("purchase_order");

            entity.Property(e => e.Ponr)
                .HasMaxLength(7)
                .IsFixedLength()
                .HasColumnName("ponr");
            entity.Property(e => e.Podate).HasColumnName("podate");
            entity.Property(e => e.Supnr)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("supnr");

            entity.HasOne(d => d.SupnrNavigation).WithMany(p => p.PurchaseOrders)
                .HasForeignKey(d => d.Supnr)
                .HasConstraintName("purchase_order_supnr_fkey");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Supnr).HasName("supplier_pkey");

            entity.ToTable("supplier");

            entity.Property(e => e.Supnr)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("supnr");
            entity.Property(e => e.Supaddress)
                .HasMaxLength(50)
                .HasColumnName("supaddress");
            entity.Property(e => e.Supcity)
                .HasMaxLength(20)
                .HasColumnName("supcity");
            entity.Property(e => e.Supname)
                .HasMaxLength(40)
                .HasColumnName("supname");
            entity.Property(e => e.Supstatus).HasColumnName("supstatus");
        });

        modelBuilder.Entity<Supply>(entity =>
        {
            entity.HasKey(e => new { e.Supnr, e.Prodnr }).HasName("supplies_pkey");

            entity.ToTable("supplies");

            entity.Property(e => e.Supnr)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("supnr");
            entity.Property(e => e.Prodnr)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("prodnr");
            entity.Property(e => e.DelivPeriod)
                .HasComment("DELIV_PERIOD IN DAYS")
                .HasColumnName("deliv_period");
            entity.Property(e => e.PurchasePrice).HasColumnName("purchase_price");

            entity.HasOne(d => d.ProdnrNavigation).WithMany(p => p.Supplies)
                .HasForeignKey(d => d.Prodnr)
                .HasConstraintName("supplies_prodnr_fkey");

            entity.HasOne(d => d.SupnrNavigation).WithMany(p => p.Supplies)
                .HasForeignKey(d => d.Supnr)
                .HasConstraintName("supplies_supnr_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
