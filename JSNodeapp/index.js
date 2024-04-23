const grpc = require('@grpc/grpc-js');
const express = require('express');
const protoLoader = require('@grpc/proto-loader');
const swaggerUi = require('swagger-ui-express');
const swaggerJsdoc = require('swagger-jsdoc');
const util = require('util');
const YAML = require('yamljs');
const { loadSync, loadPackageDefinition } = require('@grpc/proto-loader');



const app = express();
const PORT = 3000;

const packageDefinition = loadSync(__dirname + '/Protos/weather.proto');

const protoDescriptor = grpc.loadPackageDefinition(packageDefinition);

const myService = protoDescriptor.weather.Weather;

const client = new myService('localhost:32775', grpc.credentials.createInsecure());

const swaggerDocument = YAML.load('./openAPI.yaml');

app.use(express.json());

app.get('/GetAllData', (req, res) => {
    client.GetAllData({}, (error, response) => {
        if (error) {
            console.log(error.code + grpc.status.INVALID_ARGUMENT );
            if (error.code === grpc.status.INVALID_ARGUMENT) {
                res.status(400).json({ error: 'Invalid ID format' });
            } else if (error.code === grpc.status.NOT_FOUND) {
                res.status(404).json({ error: 'Weather data not found' });
            } else {
                res.status(500).json({ error: 'Internal Server Error' });
            }
            return;
        }
        res.json(response);
    });
});

app.get('/GetWeatherById/:id', (req, res) => {
    const request = { _id: req.params.id };
    client.GetWeatherById(request, (error, response) => {
        if (error) {
            console.log(error.code + grpc.status.INVALID_ARGUMENT );
            if (error.code === grpc.status.INVALID_ARGUMENT) {
                res.status(400).json({ error: 'Invalid ID format' });
            } else if (error.code === grpc.status.NOT_FOUND) {
                res.status(404).json({ error: 'Weather data not found' });
            } else {
                res.status(500).json({ error: 'Internal Server Error' });
            }
            return;
        }
        res.json(response);
    });
});

app.post('/AddWeather', (req, res) => {

    const request = {
        StationName : req.body.StationName,
        MeasurementTimestamp : req.body.MeasurementTimestamp,
        AirTemperature : req.body.AirTemeparute,
        WetBulbTemeperature : req.body.WetBulbTemperature,
        Humidity : req.body.Humidity,
        RainIntensity : req.body.RainIntensity,
        IntervalRain : req.body.IntervalRain,
        TotalRain : req.body.TotalRain,
        PrecipitationType : req.body.PrecipitationType,
        WindDirection : req.body.WindDirection,
        WindSpeed : req.body.WindSpeed,
        MaximumWindSpeed : req.body.MaximumWindSpeed,
        BiometricPressure : req.body.BiometricPressure,
        SolarRadiation : req.body.SolarRadiation,
        Heading : req.body.Heading,
        BatteryLife : req.body.BatteryLife,
        MeasurementTimestampLabel : req.body.MeasurementTimestampLabel,
        MeasurementId : req.body.MeasurementId
    };

    client.AddWeather(request, (error, response) => {
        if (error) {
            res.status(500).json({ error: 'Internal Server Error' });
            return;
        }
        res.json(response);
    });
});

app.delete('/DeleteWeather/:id', (req, res) => {
    const id = req.params.id;
    const request = { _id: id };
    client.DeleteWeather(request, (error, response) => {
        if (error) {
            if (error.code === grpc.status.INVALID_ARGUMENT) {
                res.status(400).json({ error: 'Invalid ID format' });
            } else if (error.code === grpc.status.NOT_FOUND) {
                res.status(404).json({ error: 'Weather data not found' });
            } else {
                res.status(500).json({ error: 'Internal Server Error' });
            }
            return;
        }

        res.json(response);
    });
});

app.put('/UpdateWeather', (req, res) => {
    const request = {
        StationName : req.body.StationName,
        MeasurementTimestamp : req.body.MeasurementTimestamp,
        AirTemperature : req.body.AirTemeparute,
        WetBulbTemeperature : req.body.WetBulbTemperature,
        Humidity : req.body.Humidity,
        RainIntensity : req.body.RainIntensity,
        IntervalRain : req.body.IntervalRain,
        TotalRain : req.body.TotalRain,
        PrecipitationType : req.body.PrecipitationType,
        WindDirection : req.body.WindDirection,
        WindSpeed : req.body.WindSpeed,
        MaximumWindSpeed : req.body.MaximumWindSpeed,
        BiometricPressure : req.body.BiometricPressure,
        SolarRadiation : req.body.SolarRadiation,
        Heading : req.body.Heading,
        BatteryLife : req.body.BatteryLife,
        MeasurementTimestampLabel : req.body.MeasurementTimestampLabel,
        MeasurementId : req.body.MeasurementId
    };

    client.UpdateWeather(request, (error, response) => {
        if (error) {
            if (error.code === grpc.status.INVALID_ARGUMENT) {
                res.status(400).json({ error: 'Invalid ID format' });
            } else if (error.code === grpc.status.NOT_FOUND) {
                res.status(404).json({ error: 'Weather data not found' });
            } else {
                res.status(500).json({ error: 'Internal Server Error' });
            }
            return;
        }

        res.json(response);
    });
});

app.use('/api-docs', swaggerUi.serve, swaggerUi.setup(swaggerDocument));

app.listen(PORT, () => {
    console.log(`Server is running on port ${PORT}`);
});

