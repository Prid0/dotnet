using Microsoft.EntityFrameworkCore;

namespace StudentCoreWebApi.Models;

public partial class StudentsDetailsContext : DbContext
{
    public StudentsDetailsContext()
    {
    }

    public StudentsDetailsContext(DbContextOptions<StudentsDetailsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Student__3214EC075256F7F2");

            entity.ToTable("Student");

            entity.Property(e => e.FatherName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Standard)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudentName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
