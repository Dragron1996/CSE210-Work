using System;
class SimpleGoal : Goal
{
    private string _Type = "Simple";
    private bool _Completion;
    private int _Points;

    public SimpleGoal()
    {
    }
    public SimpleGoal(string Name, string Description, int Points, bool Completion) : base (Name, Description)
    {
        _Completion = Completion;
        _Points = Points;
    }

    public override void DisplayPoints()
    {
        Console.Write("How many points is this goal worth? ");
        _Points = int.Parse(Console.ReadLine());
        return;
    }
    public override int GetPoints()
    {
        return _Points;
    }
    
    public override bool GetStatus()
    {
        return _Completion;
    }

    public override string ToCSVRecord()
    {
        return $"{_Type}|{GetName()}|{GetDescription()}|{GetPoints()}|{_Completion}";
    }

    public override string ToString()
    {
        return $"[{((_Completion == false) ? " " : "x")}] {GetName()} ({GetDescription()})";
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        _Completion = true;
    }
}