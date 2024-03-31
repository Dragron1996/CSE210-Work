using System;


public class EternalGoal : Goal
{
    private string _Type = "Eternal";
    private int _Points;
    private int _GotItDone = 0;
    private bool _Completion = false;

    public EternalGoal()
    {
    }
    public EternalGoal(string Name, string Description, int Points, int GotItDone, bool Completion) : base (Name, Description)
    {
        _Points = Points;
        _GotItDone = GotItDone;
        _Completion = Completion;
    }
        public int GetRunningTotal()
    {
        return _GotItDone;
    }

    public override void DisplayPoints()
    {
        Console.Write("How many points is this goal worth each time you complete it? ");
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
        return $"{_Type}|{GetName()}|{GetDescription()}|{GetPoints()}|{GetRunningTotal()}|{_Completion}";
    }

    public override string ToString()
    {
        return $"[ ] {GetName()} ({GetDescription()}) - Completed {GetRunningTotal()} times";
    }

    public override void RecordEvent()
    {
        _GotItDone += 1;
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }
}