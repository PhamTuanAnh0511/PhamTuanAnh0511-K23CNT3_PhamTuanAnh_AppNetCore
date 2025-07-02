using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PhamTuanAnh_2310900003.Models;

public partial class Phamtuananh2310900003Context : DbContext
{
    public Phamtuananh2310900003Context()
    {
    }

    public Phamtuananh2310900003Context(DbContextOptions<Phamtuananh2310900003Context> options)
        : base(options)
    {
    }

    public virtual DbSet<PtaEmployee> PtaEmployees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=MSI\\PHAMTUAN;Database=phamtuananh_2310900003;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PtaEmployee>(entity =>
        {
            entity.HasKey(e => e.PtaEmpId).HasName("PK__PtaEmplo__A7013429F70C0F11");

            entity.ToTable("PtaEmployee");

            entity.Property(e => e.PtaEmpId).ValueGeneratedNever();
            entity.Property(e => e.PtaEmpLevel).HasMaxLength(50);
            entity.Property(e => e.PtaEmpName).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
