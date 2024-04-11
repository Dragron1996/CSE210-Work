using System;

public class OutdoorGathering : Event
{
    private string _weather;
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }

    public string GetWeatherStatement()
    {
        return "The weather will be " + _weather + ".";
    }

    public string ReturnEventType()
    {
        return "Outdoor Gathering";
    }
    public string GetLongOutdoorGathering()
    {
        string detailed = "";
        string weatherStatement = GetWeatherStatement();
        
        detailed += GetStandard() + "\n";
        detailed += "Statement of the Weather: " + weatherStatement;
        return detailed;
    }
    public string GetOutdoorGathering()
    {
        string OutdoorGathering = "";
        string eventType = ReturnEventType();

        OutdoorGathering += "Event Type: " + eventType + "\n";
        OutdoorGathering += GetBasic();
        return OutdoorGathering;
    }
}