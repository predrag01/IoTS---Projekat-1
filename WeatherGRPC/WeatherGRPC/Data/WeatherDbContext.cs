using Google.Protobuf.WellKnownTypes;
using Microsoft.EntityFrameworkCore;

namespace WeatherGRPC.Data
{
    public class WeatherDbContext : DbContext
    {
        public DbSet<WeatherValue> WeatherData { get; set; } = null!;
        public WeatherDbContext(DbContextOptions<WeatherDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherValue>()
                .HasKey(e => e.MeasurementId);

            modelBuilder
                .Entity<WeatherValue>()
                .Property(e => e.MeasurementId)
                .ValueGeneratedOnAdd();

            //modelBuilder
            //    .Entity<WeatherValue>()
            //    .Property(e => e.MeasurementTimestamp)
            //    .HasConversion(
            //          v => v.ToDateTime(),
            //          v => v.ToTimestamp()
            //          );

            //modelBuilder
            //    .Entity<WeatherValue>()
            //    .Property(e => e.MeasurementTimestampLabel)
            //    .HasConversion(
            //          v => v.ToDateTime(),
            //          v => v.ToTimestamp()
            //          );
        }
    }
}
