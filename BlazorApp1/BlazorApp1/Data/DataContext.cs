using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Models;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<User> Users { get; set; }
    public DbSet<Profile> Profiles { get; set; }
    public DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Social.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasMany(u => u.Posts)
                .WithOne(p => p.user)
                .HasForeignKey(p => p.UserId)
                .HasPrincipalKey(e => e.UserId);
            entity.HasMany(u => u.Friends)
                .WithMany();
            entity.HasOne(u => u.UserProfile)
                .WithOne(p => p.user)
                .HasForeignKey<Profile>(p => p.UserId);
        });

        modelBuilder.Entity<Profile>(entity =>
            {
                entity.HasKey(p => p.ProfileId);
            }
        );

        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(p => p.PostId);
        });
    }
}