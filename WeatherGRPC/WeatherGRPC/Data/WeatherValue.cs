﻿using Google.Protobuf.WellKnownTypes;
using System.ComponentModel.DataAnnotations;

namespace WeatherGRPC.Data
{
    public class WeatherValue
    {
        public string StationName { get; set; }
        public string MeasurementTimestamp { get; set; }
        public float AirTemperature { get; set; }
        public float WetBulbTemeperature { get; set; }
        public int Humidity { get; set; }
        public float RainIntensity { get; set; }
        public float IntervalRain { get; set; }
        public float TotalRain { get; set; }
        public int PrecipitationType { get; set; }
        public float WindDirection { get; set; }
        public float WindSpeed { get; set; }
        public float MaximumWindSpeed { get; set; }
        public float BiometricPressure { get; set; }
        public int SolarRadiation { get; set; }
        public int Heading { get; set; }
        public float BatteryLife { get; set; }
        public string MeasurementTimestampLabel { get; set; }
        [Key]
        public string MeasurementId { get; set; }
    }
}
