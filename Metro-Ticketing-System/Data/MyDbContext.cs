using Metro_Ticketing_System.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Text.Json;

namespace Metro_Ticketing_System.Data
{
    public class MyDbContext :DbContext
    {
        public DbSet<Station> Stations { get; set; }
        public DbSet<Line> Lines { get; set; }
       
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Line>().HasData(
               new Line { Id = 1, Name = "Line1" },
               new Line { Id = 2, Name = "Line2" });

            var stations = LoadStationsFromJson();
            modelBuilder.Entity<Station>().HasData(stations);
        }
        private List<Station> LoadStationsFromJson()
        {
            var jsonData = File.ReadAllText("SeedData/Stations.json");
            var stations = JsonSerializer.Deserialize<List<Station>>(jsonData);
            return stations;
        }
    }
}
