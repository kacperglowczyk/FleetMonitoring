using System;
using Microsoft.EntityFrameworkCore;

namespace FleetMonitoring.Models
{
    public class Record
    {
        public int Id { get; set; }
        public int DriverId { get; set; }
        public DateTime TripDate { get; set; }
        public string TripLength { get; set; }
    }

    public class RecordContext : DbContext
    {
        public DbSet<Record> Records { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Database.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Record>()
                .HasKey(r => r.Id);

            modelBuilder.Entity<Record>()
                .Property(r => r.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Record>()
                .Property(r => r.DriverId)
                .IsRequired();

            modelBuilder.Entity<Record>()
                .Property(r => r.TripDate)
                .IsRequired();

            modelBuilder.Entity<Record>()
                .Property(r => r.TripLength)
                .IsRequired();

        }
    }
}


