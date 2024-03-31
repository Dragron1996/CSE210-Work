using System;
class AllGoals
{
    private List<Goal> _allThree = new List<Goal>();
    private int _total;
    private string _file;

    public void adding(Goal _goal)
    {
        _allThree.Add(_goal);
    }

    public int Total()
    {
        return _total;
    }

    public void Points(int total)
    {
        
        Console.WriteLine($"Total Points: {total}");
    }

    public void Goals()
    {
        if (_allThree.Count() == 0)
        {
            Console.WriteLine("No goals have been created or loaded.");
            return;
        }
        Console.WriteLine("Your goals:");
        foreach (Goal goal in _allThree)
        {
            Console.WriteLine($"{_allThree.IndexOf(goal) + 1}. {goal.ToString()}");
        }
        Console.WriteLine();
    }

    public void Save()
    {
        if (_allThree.Count() == 0)
        {
            Console.WriteLine("There are no goals to save.");
            Console.WriteLine();
            return;
        }
    
        Console.WriteLine("Please enter the filename you want to save: ");
        _file = Console.ReadLine();
        string savedfile = _file;
        List<string> save = new List<string>();
        save.Add(_total.ToString());
        foreach (Goal goal in _allThree)
        {
            save.Add(goal.ToCSVRecord());
        }
        SaveLoadCSV.SaveFile(save, savedfile);
        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        List<string> fileGoals;
        Console.WriteLine("Please enter the filename you want to load: ");
        _file = Console.ReadLine();
        fileGoals = SaveLoadCSV.LoadCSV(_file);
        _total = int.Parse(fileGoals[0]) + _total;

        Goal goal = null;
        foreach (string fileGoal in fileGoals)
        {
            
            string[] section = fileGoal.Split('|');
            string Type = section[0];
            if (Type == "Simple")
            {
                goal = new SimpleGoal(section[1], section[2], int.Parse(section[3]), bool.Parse(section[4]));
            }
            else if (Type == "Eternal")
            {
                goal = new EternalGoal(section[1], section[2], int.Parse(section[3]), int.Parse(section[4]), bool.Parse(section[5]));
            }
            else if (Type == "CheckList")
            {
                goal = new CheckListGoal(section[1], section[2], int.Parse(section[3]), int.Parse(section[4]), int.Parse(section[5]), int.Parse(section[6]), bool.Parse(section[7]));
            }

            if (goal != null && _allThree.Contains(goal) == false)
            {
                _allThree.Add(goal);
            }
        }
        Console.WriteLine("Goals loaded.");
    }

    public void DisplayRecordEvent()
    {
        Console.WriteLine("The Goals are:");
        foreach (Goal goal in _allThree)
        {
            Console.WriteLine(string.Format($"{_allThree.IndexOf(goal) + 1}. [{((goal.GetStatus() == false) ? " " : "x")}] {goal.GetName()}"));
        }
        Console.Write("Which goal did you complete? ");
        int recordEvent = int.Parse(Console.ReadLine()) - 1;
        Console.Clear();
        bool status = _allThree[recordEvent].GetStatus();
        if (status == false)
        {
            _allThree[recordEvent].RecordEvent();
            _total += _allThree[recordEvent].GetPoints();
            Console.WriteLine(string.Format($"You now have {_total.ToString()} points!"));
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("You have already completed that goal!");
            Console.WriteLine();
        }
    }
}