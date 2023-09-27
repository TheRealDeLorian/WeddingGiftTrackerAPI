using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WeddingGiftTrackerAPI.Data.Models;

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
            entity.Property(e => e.Guestname)
                .HasMaxLength(1000)
                .HasColumnName("guestname");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
