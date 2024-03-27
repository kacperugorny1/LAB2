using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class WeatherDbContext : DbContext
    {
        public DbSet<Weather>? Weathers { set; get; }
        public DbSet<City>? Cities { set; get; }
        public WeatherDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"Data Source = Database.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City(1,"Wroclaw", 51.10, 17.03),
                new City(2,"Warszawa", 52.23, 21.01)
                );
            modelBuilder.Entity<Weather>().HasData(
                new Weather(1, "Vancouver", 0, DateTime.MinValue),
                new Weather(2, "Vancouverr", 1, DateTime.MinValue)
                );
        }

    }
}
