using System;
using Microsoft.EntityFrameworkCore;

namespace FleetMonitoring.Models
{
    public class Car
    {
        public int Id { get; set; }
        public int DriverId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Vin { get; set; }
        public int Mileage { get; set; }
    }

    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Database.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Car>()
                .Property(c => c.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Car>()
                .Property(c => c.DriverId)
                .IsRequired();

            modelBuilder.Entity<Car>()
                .Property(c => c.Make)
                .IsRequired();

            modelBuilder.Entity<Car>()
                .Property(c => c.Model)
                .IsRequired();

            modelBuilder.Entity<Car>()
                .Property(c => c.Year)
                .IsRequired();

            modelBuilder.Entity<Car>()
                .Property(c => c.Vin)
                .IsRequired();

            modelBuilder.Entity<Car>()
                .Property(c => c.Mileage)
                .IsRequired();
        }
    }
}

