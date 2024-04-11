using System;

public class Reception : Event
{
    private string _email;
    public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public string GetEmail()
    {
        return _email;
    }

    public string ReturnEventType()
    {
        return "Reception";
    }

    public string GetLongReception()
    {
        string detailed = GetStandard() + "\n";
        detailed += "RSVP: " + _email;
        return detailed;
    }
    public string GetReception()
    {
        string Reception = "";
        string eventType = ReturnEventType();
        Reception += "Event Type: " + eventType + "\n";
        Reception += GetBasic();
        return Reception;
    }
}