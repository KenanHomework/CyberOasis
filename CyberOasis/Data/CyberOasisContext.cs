using CyberOasis.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace CyberOasis.Data;

public class CyberOasisContext : DbContext 
{
    public CyberOasisContext(DbContextOptions<CyberOasisContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Entry => *User relation
        modelBuilder.Entity<Entry>()
            .HasOne(e => e.User)
            .WithMany(u => u.Entries);



        // Entry => *Category relation
        modelBuilder.Entity<Entry>()
            .HasOne(e => e.Category)
            .WithMany(c => c.Entries);

          

        /* *Entry => *User relation.Favorite Cross table. */
        modelBuilder.Entity<Favorite>()
            .HasKey(f => new { f.EntryId, f.UserId });

        modelBuilder.Entity<Favorite>()
            .HasOne(f => f.Entry)
            .WithMany(e => e.FavoriteUsers)
            .HasForeignKey(e => e.EntryId)
            .OnDelete(DeleteBehavior.Restrict);


        modelBuilder.Entity<Favorite>()
            .HasOne(f => f.User)
            .WithMany(e => e.FavoriteEntries)
            .HasForeignKey(e => e.UserId)
            .OnDelete(DeleteBehavior.Restrict);




        /* *Entry => *User relation.Vote Cross table. */
        modelBuilder.Entity<Vote>()
            .HasKey(v => new { v.EntryId, v.UserId });

        modelBuilder.Entity<Vote>()
            .HasOne(v => v.Entry)
            .WithMany(e => e.VoteUsers)
            .HasForeignKey(e => e.EntryId)
            .OnDelete(DeleteBehavior.Restrict);


        modelBuilder.Entity<Vote>()
            .HasOne(v => v.User)
            .WithMany(e => e.VoteEntries)
            .HasForeignKey(e => e.UserId)
            .OnDelete(DeleteBehavior.Restrict);





        /* *Entry => *User relation.Follow Cross table. */
        modelBuilder.Entity<Follow>()
            .HasKey(f => new { f.FollowerId, f.FollowedId });

        modelBuilder.Entity<Follow>()
            .HasOne(f => f.Follower)
            .WithMany(u => u.FollowedUsers)
            .HasForeignKey(f => f.FollowerId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Follow>()
            .HasOne(f => f.Followed)
            .WithMany(u => u.Followers)
            .HasForeignKey(f => f.FollowedId)
            .OnDelete(DeleteBehavior.Restrict);

    }

    public DbSet<User> Users { get; set; } = default!;
    public DbSet<Entry> Entries { get; set; } = default!;
    public DbSet<Category> Categories { get; set; } = default!;
}
