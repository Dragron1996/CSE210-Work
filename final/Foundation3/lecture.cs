using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetSpeaker()
    {
        return _speaker;
    }
    public int GetCapacity()
    {
        return _capacity;
    }
    public string ReturnEventType()
    {
        return "Lecture";
    }

    public string GetLongLecture()
    {
        string detailed = GetStandard() + "\n";

        detailed += "Speaker: " + _speaker + "\n";
        detailed += "Capacity: " + _capacity +  " max";
        return detailed;
    }

    public string GetLecture()
    {
        string Lecture = "";
        string eventType = ReturnEventType();

        Lecture += "Event Type: " + eventType + "\n";
        Lecture += GetBasic();
        return Lecture;
    }
    
}