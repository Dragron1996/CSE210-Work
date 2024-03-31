using System;
public class Goal
{
    private string _Name;
    private string _Description;

    public Goal()
    {}
    public Goal(string Name, string Description)
    {
        _Name = Name;
        _Description = Description;
    }

    public string GetName()
    {
        return _Name;
    }
    public void SetName(string Name)
    {
        _Name = Name;
    }
    public string GetDescription()
    {
        return _Description;
    }
    public void SetDescription(string Description)
    {
        _Description = Description;
    }

       public virtual void DisplayPoints()
    {
        return;
    }
    public virtual int GetPoints()
    {
        return 0;
    }

    public virtual bool GetStatus()
    {
        return false;
    }

    public virtual string ToCSVRecord()
    {
        return "";
    }
    public virtual void RecordEvent()
    {
    }

    public string DisplayName()
    {
        Console.Write("What is the name of your goal? ");
        _Name = Console.ReadLine();
        return _Name;
    }

    public string DisplayDescription()
    {
        Console.Write("What is the description of your goal? ");
        _Description = Console.ReadLine();
        return _Description;
    }

 
}