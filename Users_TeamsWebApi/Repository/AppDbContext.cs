using Microsoft.EntityFrameworkCore;
using Users_TeamsWebApi.Data.Models;

namespace Users_TeamsWebApi.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Status>()
        //        .HasMany(c => c.Users)
        //        .WithOne(c => c.Status)
        //        .IsRequired();


        //    modelBuilder.Entity<Team>()
        //        .HasMany(c => c.Users)
        //        .WithOne(c => c.Team)
        //        .IsRequired();
        //}
        public DbSet<User> Users { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Status> Statuses { get; set; }
    }
}
