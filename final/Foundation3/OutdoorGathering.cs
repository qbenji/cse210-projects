using System;
using System.Formats.Asn1;

public class OutdoorGathering : Event
{   
    private int _temperature;
    private string _sky;
    private int _humidity;
    private int _precipitation;
    private int _windSpeed;
    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string eventType, int temperature, string sky, int humidity, int precipitation, int windSpeed)     // constructor
        : base(title, description, date, time, address, eventType)
    {
        _temperature = temperature;
        _sky = sky;
        _humidity = humidity;
        _precipitation = precipitation;
        _windSpeed = windSpeed;
    }

    public override string FullDetails()                // get full details
    {
        return $"{GetEventType()} - {GetTitle()}\n" 
        + $"{GetDescription()}\n\n  {GetAddress()}\n   {GetDate()} @ {GetTime()}\n\n"
        + $"Temperature: {_temperature}\nSky: {_sky}\nHumidity: {_humidity}\n" 
        + $"Precipitation: {_precipitation}\nWind Speed: {_windSpeed}";
    }

    public int GetTemperature()                         // get temperature
    {
        return _temperature;
    }

    public string GetSky()                              // get sky
    {
        return _sky;
    }

    public int GetHumidity()                            // get humidity
    {
        return _humidity;
    }

    public int GetPrecipitation()                       // get precipitation
    {
        return _precipitation;
    }

    public int GetWindSpeed()                           // get windSpeed
    {
        return _windSpeed;
    }
    
    public void SetTemperature(int temperature)         // set temperature
    {
        _temperature = temperature;
    }

    public void SetSky(string sky)                      // set sky
    {
        _sky = sky;
    }

    public void SetHumidity(int humidity)               // set humidity
    {
        _humidity = humidity;
    }

    public void SetPrecipitation(int precipitation)     // set precipitation
    {
        _precipitation = precipitation;
    }

    public void SetWindSpeed(int windSpeed)             // set windSpeed
    {
        _windSpeed = windSpeed;
    }

}