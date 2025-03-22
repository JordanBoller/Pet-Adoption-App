using midterm_project.Models;
using Microsoft.EntityFrameworkCore;

namespace midterm_project.Migrations;

public class PetDbContext : DbContext
{
    public DbSet<Pet> Pets { get; set; }

    public PetDbContext(DbContextOptions<PetDbContext> options)
    : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Pet>(entity =>
        {
            entity.HasKey(e => e.PetId);
            entity.Property(e => e.PetName).IsRequired();
            entity.Property(e => e.ImgUrl).IsRequired();
            entity.Property(e => e.PetDescription).IsRequired();
        });
    }
}