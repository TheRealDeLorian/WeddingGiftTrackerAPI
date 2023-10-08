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

  

    public virtual DbSet<Gift> Gifts { get; set; }

    public virtual DbSet<GiftGuest> GiftGuests { get; set; }

    public virtual DbSet<GiftType> Gifttypes { get; set; }

    public virtual DbSet<Guest> Guests { get; set; }

   

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("name=DbConnectionString");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       

        modelBuilder.Entity<Gift>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gift_pkey");

            entity.ToTable("gift", "weddinggifttracker");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasColumnName("description");
            entity.Property(e => e.GiftName)
                .HasMaxLength(100)
                .HasColumnName("giftname");
            entity.Property(e => e.GiftType).HasColumnName("gifttype");

            entity.HasOne(d => d.GiftTypeNavigation).WithMany(p => p.Gifts)
                .HasForeignKey(d => d.GiftType)
                .HasConstraintName("gift_gifttype_fkey");
        });

        modelBuilder.Entity<GiftGuest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gift_guest_pkey");

            entity.ToTable("gift_guest", "weddinggifttracker");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GiftId).HasColumnName("giftid");
            entity.Property(e => e.GuestId).HasColumnName("guestid");

            entity.HasOne(d => d.Gift).WithMany(p => p.GiftGuests)
                .HasForeignKey(d => d.GiftId)
                .HasConstraintName("gift_guest_giftid_fkey");

            entity.HasOne(d => d.Guest).WithMany(p => p.GiftGuests)
                .HasForeignKey(d => d.GuestId)
                .HasConstraintName("gift_guest_guestid_fkey");
        });

        modelBuilder.Entity<GiftType>(entity =>
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
            entity.Property(e => e.GuestName)
                .HasMaxLength(1000)
                .HasColumnName("guestname");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
