using System;
public class CheckListGoal : Goal
{
    private string _Type = "CheckList";
    private int _Points;
    private int _Times;
    private int _Bonuspoints;
    private int _GotItDone = 0;
    private int _totalPoints = 0;
    private bool _Completion;

    public CheckListGoal()
    {
    }

    public CheckListGoal(string Name, string Description, int Points, int Times, int GotItDone, int Bonuspoints, bool Completion) : base (Name, Description)
    {
        _Points = Points;
        _Times = Times;
        _GotItDone = GotItDone;
        _Bonuspoints = Bonuspoints;
        _Completion = Completion;
    }

    public override void DisplayPoints()
    {
        Console.Write("How many times do you want to complete this goal? ");
        _Times = int.Parse(Console.ReadLine());
        Console.Write("How many points is this goal worth each time you do it? ");
        _Points = int.Parse(Console.ReadLine());
        Console.Write($"How much is the bonus for completing this goal? ");
        _Bonuspoints = int.Parse(Console.ReadLine());
        return;
    }
    public int Points()
    {
        return _Points;
    }
    public override int GetPoints()
    {
        if (_GotItDone == _Times)
        {
            _totalPoints = _Points + _Bonuspoints;
        }
        else if (_GotItDone < _Times)
        {
            _totalPoints = _Points;
        }
        return _totalPoints;
    }
    public int GetTimes()
    {
        return _Times;
    }
    public int GetBonus()
    {
        return _Bonuspoints;
    }
    public int GetRunningTimes()
    {
        return _GotItDone;
    }
    
    public override bool GetStatus()
    {
        return _Completion;
    }

    public override string ToCSVRecord()
    {
        return $"{_Type}|{GetName()}|{GetDescription()}|{Points()}|{GetTimes()}|{GetRunningTimes()}|{GetBonus()}|{_Completion}";
    }

    public override string ToString()
    {
        return $"[{((_Completion == false) ? " " : "x")}] {GetName()} ({GetDescription()}) - Currently Completed: {GetRunningTimes()}/{GetTimes()}";
    }

    public override void RecordEvent()
    {
        _GotItDone += 1;
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        if (_GotItDone < _Times)
        {
            _Completion = false;
        }
        else if (_GotItDone >= _Times)
        {
            _Completion = true;
            Console.WriteLine("You completed this goal & earned the bonus points!");
        }
     
    }
}