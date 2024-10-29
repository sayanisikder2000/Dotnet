using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CarEngineDbFirstApproach.Models;

public partial class CarEngineRelationshipContext : DbContext
{
    public CarEngineRelationshipContext()
    {
    }

    public CarEngineRelationshipContext(DbContextOptions<CarEngineRelationshipContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CarTbl> CarTbls { get; set; }

    public virtual DbSet<EngineTbl> EngineTbls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-5E9DNII\\SAYANIDATABASE;Initial Catalog=CarEngineRelationship;User Id=sa;Password=user123;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CarTbl>(entity =>
        {
            entity.HasKey(e => e.CarId);

            entity.ToTable("CarTbl");

            entity.Property(e => e.CarId).ValueGeneratedNever();
            entity.Property(e => e.CarBrand)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CarColor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CarModel)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Engine).WithMany(p => p.CarTbls)
                .HasForeignKey(d => d.EngineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CarTbl_EngineTbl");
        });

        modelBuilder.Entity<EngineTbl>(entity =>
        {
            entity.HasKey(e => e.EngineId);

            entity.ToTable("EngineTbl");

            entity.Property(e => e.EngineId).ValueGeneratedNever();
            entity.Property(e => e.EngineBrand)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EngineModel)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
