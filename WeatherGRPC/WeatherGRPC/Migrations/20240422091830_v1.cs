using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeatherGRPC.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeatherData",
                columns: table => new
                {
                    StationName = table.Column<string>(type: "text", nullable: true),
                    MeasurementTimestamp = table.Column<string>(type: "text", nullable: true),
                    AirTemperature = table.Column<float>(type: "real", nullable: true),
                    WetBulbTemeperature = table.Column<float>(type: "real", nullable: true),
                    Humidity = table.Column<int>(type: "integer", nullable: true),
                    RainIntensity = table.Column<float>(type: "real", nullable: true),
                    IntervalRain = table.Column<float>(type: "real", nullable: true),
                    TotalRain = table.Column<float>(type: "real", nullable: true),
                    PrecipitationType = table.Column<int>(type: "integer", nullable: true),
                    WindDirection = table.Column<float>(type: "real", nullable: true),
                    WindSpeed = table.Column<float>(type: "real", nullable: true),
                    MaximumWindSpeed = table.Column<float>(type: "real", nullable: true),
                    BiometricPressure = table.Column<float>(type: "real", nullable: true),
                    SolarRadiation = table.Column<int>(type: "integer", nullable: true),
                    Heading = table.Column<int>(type: "integer", nullable: true),
                    BatteryLife = table.Column<float>(type: "real", nullable: true),
                    MeasurementTimestampLabel = table.Column<string>(type: "text", nullable: true),
                    MeasurementId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherData", x => x.MeasurementId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherData");
        }
    }
}
