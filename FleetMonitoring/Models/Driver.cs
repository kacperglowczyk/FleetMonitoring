using System;
using Microsoft.EntityFrameworkCore;

namespace FleetMonitoring.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string DriverName { get; set; }
        public string DriverSurname { get; set; }        
    }

    public class DriverContext : DbContext
    {
        public DbSet<Driver> Drivers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Database.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Driver>()
                .HasKey(d => d.Id);

            modelBuilder.Entity<Driver>()
                .Property(d => d.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Driver>()
                .Property(d => d.DriverName)
                .IsRequired();

            modelBuilder.Entity<Driver>()
                .Property(d => d.DriverSurname)
                .IsRequired();
           
        }
    }

}

