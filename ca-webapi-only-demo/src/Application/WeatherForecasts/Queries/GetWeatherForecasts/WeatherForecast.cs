﻿namespace ca_webapi_only_demo.Application.WeatherForecasts.Queries.GetWeatherForecasts;

public class WeatherForecast
{
    public DateTime Date { get; init; }

    public int TemperatureC { get; init; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; init; }
}
