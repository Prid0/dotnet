using Microsoft.EntityFrameworkCore;

namespace EmployeeCoreWebApi.Models;

public partial class EmoloyeeContext : DbContext
{
    public EmoloyeeContext()
    {
    }

    public EmoloyeeContext(DbContextOptions<EmoloyeeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__Employee__C190176BB767B8F4");

            entity.ToTable("Employee");

            entity.Property(e => e.Eid).HasColumnName("EId");
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FatherName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Post)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
