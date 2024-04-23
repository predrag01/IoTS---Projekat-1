using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics.Metrics;
using WeatherGRPC;
using WeatherGRPC.Data;

namespace WeatherGRPC.Services
{
    public class Service : Weather.WeatherBase
    {
        private readonly WeatherDbContext _db;

        public Service(WeatherDbContext db)
        {
            _db = db;
        }

        public override async Task GetAllData(EmptyMessage request, IServerStreamWriter<WeatherValues> responseStream, ServerCallContext context)
        {
            try
            {
                var logValues = await _db.WeatherData.ToListAsync();
                foreach (var lv in logValues)
                {
                    await responseStream.WriteAsync(new WeatherValues
                    {
                        StationName = lv.StationName,
                        MeasurementTimestamp = lv.MeasurementTimestamp,
                        AirTemeparute = lv.AirTemperature,
                        WetBulbTemperature = lv.WetBulbTemeperature,
                        Humidity = lv.Humidity,
                        RainIntensity = lv.RainIntensity,
                        IntervalRain = lv.IntervalRain,
                        TotalRain = lv.TotalRain,
                        PrecipitationType = lv.PrecipitationType,
                        WindDirection = lv.WindDirection,
                        WindSpeed = lv.WindSpeed,
                        MaximumWindSpeed = lv.MaximumWindSpeed,
                        BiometricPressure = lv.BiometricPressure,
                        SolarRadiation = lv.SolarRadiation,
                        Heading = lv.Heading,
                        BatteryLife = lv.BatteryLife,
                        MeasurementTimestampLabel = lv.MeasurementTimestampLabel,
                        MeasurementId = lv.MeasurementId
                    });
                }
            }
            catch (Exception e)
            {
                throw new RpcException(new Status(StatusCode.Internal, e.Message));
            }

        }

        public override async Task<WeatherValues> GetWeatherById(WeatherId weatherId, ServerCallContext context)
        {
            try
            {
                var lv = await _db.WeatherData.FindAsync(weatherId.MeasurementId);

                return await Task.FromResult(new WeatherValues
                {
                    StationName = lv.StationName,
                    MeasurementTimestamp = lv.MeasurementTimestamp,
                    AirTemeparute = lv.AirTemperature,
                    WetBulbTemperature = lv.WetBulbTemeperature,
                    Humidity = lv.Humidity,
                    RainIntensity = lv.RainIntensity,
                    IntervalRain = lv.IntervalRain,
                    TotalRain = lv.TotalRain,
                    PrecipitationType = lv.PrecipitationType,
                    WindDirection = lv.WindDirection,
                    WindSpeed = lv.WindSpeed,
                    MaximumWindSpeed = lv.MaximumWindSpeed,
                    BiometricPressure = lv.BiometricPressure,
                    SolarRadiation = lv.SolarRadiation,
                    Heading = lv.Heading,
                    BatteryLife = lv.BatteryLife,
                    MeasurementTimestampLabel = lv.MeasurementTimestampLabel,
                    MeasurementId = lv.MeasurementId
                });
            }
            catch (Exception e)
            {
                throw new RpcException(new Status(StatusCode.Internal, e.Message));
            }
        }

        public override async Task<WeatherValues> AddWeather(WeatherValues weatherValues, ServerCallContext context)
        {
            var lv = new WeatherValue()
            {
                StationName = weatherValues.StationName,
                MeasurementTimestamp = weatherValues.MeasurementTimestamp,
                AirTemperature = weatherValues.AirTemeparute,
                WetBulbTemeperature = weatherValues.WetBulbTemperature,
                Humidity = weatherValues.Humidity,
                RainIntensity = weatherValues.RainIntensity,
                IntervalRain = weatherValues.IntervalRain,
                TotalRain = weatherValues.TotalRain,
                PrecipitationType = weatherValues.PrecipitationType,
                WindDirection = weatherValues.WindDirection,
                WindSpeed = weatherValues.WindSpeed,
                MaximumWindSpeed = weatherValues.MaximumWindSpeed,
                BiometricPressure = weatherValues.BiometricPressure,
                SolarRadiation = weatherValues.SolarRadiation,
                Heading = weatherValues.Heading,
                BatteryLife = weatherValues.BatteryLife,
                MeasurementTimestampLabel = weatherValues.MeasurementTimestampLabel,
                MeasurementId = weatherValues.MeasurementId
            };

            await _db.WeatherData.AddAsync(lv);
            await _db.SaveChangesAsync();

            return await Task.FromResult(new WeatherValues
            {
                StationName = lv.StationName,
                MeasurementTimestamp = lv.MeasurementTimestamp,
                AirTemeparute = lv.AirTemperature,
                WetBulbTemperature = lv.WetBulbTemeperature,
                Humidity = lv.Humidity,
                RainIntensity = lv.RainIntensity,
                IntervalRain = lv.IntervalRain,
                TotalRain = lv.TotalRain,
                PrecipitationType = lv.PrecipitationType,
                WindDirection = lv.WindDirection,
                WindSpeed = lv.WindSpeed,
                MaximumWindSpeed = lv.MaximumWindSpeed,
                BiometricPressure = lv.BiometricPressure,
                SolarRadiation = lv.SolarRadiation,
                Heading = lv.Heading,
                BatteryLife = lv.BatteryLife,
                MeasurementTimestampLabel = lv.MeasurementTimestampLabel,
                MeasurementId = lv.MeasurementId
            });
        }

        public override async Task<WeatherValues> UpdateWeather(WeatherValues weatherValues, ServerCallContext context)
        {
            var lv = await _db.WeatherData.FindAsync(weatherValues.MeasurementId);

            lv.StationName = weatherValues.StationName;
            lv.MeasurementTimestamp = weatherValues.MeasurementTimestamp;
            lv.AirTemperature = weatherValues.AirTemeparute;
            lv.WetBulbTemeperature = weatherValues.WetBulbTemperature;
            lv.Humidity=weatherValues.Humidity;
            lv.RainIntensity = weatherValues.RainIntensity;
            lv.IntervalRain = weatherValues.IntervalRain;
            lv.TotalRain = weatherValues.TotalRain;
            lv.PrecipitationType = weatherValues.PrecipitationType;
            lv.WindDirection = weatherValues.WindDirection;
            lv.WindSpeed = weatherValues.WindSpeed;
            lv.MaximumWindSpeed = weatherValues.MaximumWindSpeed;
            lv.BiometricPressure = weatherValues.BiometricPressure;
            lv.SolarRadiation = weatherValues.SolarRadiation;
            lv.Heading = weatherValues.Heading;
            lv.BatteryLife = weatherValues.BatteryLife;
            lv.MeasurementTimestampLabel = weatherValues.MeasurementTimestampLabel;

            _db.WeatherData.Update(lv);
            await _db.SaveChangesAsync();

            return await Task.FromResult(new WeatherValues
            {
                StationName = lv.StationName,
                MeasurementTimestamp = lv.MeasurementTimestamp,
                AirTemeparute = lv.AirTemperature,
                WetBulbTemperature = lv.WetBulbTemeperature,
                Humidity = lv.Humidity,
                RainIntensity = lv.RainIntensity,
                IntervalRain = lv.IntervalRain,
                TotalRain = lv.TotalRain,
                PrecipitationType = lv.PrecipitationType,
                WindDirection = lv.WindDirection,
                WindSpeed = lv.WindSpeed,
                MaximumWindSpeed = lv.MaximumWindSpeed,
                BiometricPressure = lv.BiometricPressure,
                SolarRadiation = lv.SolarRadiation,
                Heading = lv.Heading,
                BatteryLife = lv.BatteryLife,
                MeasurementTimestampLabel = lv.MeasurementTimestampLabel,
                MeasurementId = lv.MeasurementId
            });
        }

        public override async Task<EmptyMessage> DeleteWeather(WeatherId weatherId, ServerCallContext context)
        {
            var lv = await _db.WeatherData.FindAsync(weatherId.MeasurementId);
            _db.WeatherData.Remove(lv);
            await _db.SaveChangesAsync();

            return await Task.FromResult(new EmptyMessage { });
        }
    }
}
