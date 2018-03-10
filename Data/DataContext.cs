using DatingApp.API.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Value> Value { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Photo> Photos { get; set; }

        public DbSet<Like> Likes { get; set; }

        protected override void OnModelCreating(ModelBuilder builer)
        {
            builer.Entity<Like>()
                .HasKey(k => new { k.LikerId, k.LikeeId });

            builer.Entity<Like>()
            .HasOne(u => u.Likee)
            .WithMany(u => u.Liker)
            .HasForeignKey(u => u.LikerId)
            .OnDelete(DeleteBehavior.Restrict);

            builer.Entity<Like>()
            .HasOne(u => u.Liker)
            .WithMany(u => u.Likee)
            .HasForeignKey(u => u.LikeeId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}