using System;
using Microsoft.EntityFrameworkCore;

namespace FleetMonitoring.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public int DriverId { get; set; }
        public DateTime Date { get; set; }
        public int TripLength { get; set; }
    }

    public class TripContext : DbContext
    {
        public DbSet<Trip> Trips { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Database.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trip>()
                .HasKey(t => t.Id);

            modelBuilder.Entity<Trip>()
                .Property(t => t.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Trip>()
                .Property(t => t.DriverId)
                .IsRequired();

            modelBuilder.Entity <Trip>()
                .Property(t => t.Date)
                .IsRequired();

            modelBuilder.Entity<Trip>()
                .Property(t => t.TripLength)
                .IsRequired();
            
        }
    }
}

