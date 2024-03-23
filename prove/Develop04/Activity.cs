using System;

public class Activity
{
    
    private string _Name;
    private int _Time;
    private string text = "Starting...";

    public Activity(string Name, int Time)
    {
        _Name = Name;
        _Time = Time;
    }
    public void GetName()
    {
        Console.WriteLine($"Welcome to the {_Name} Activity\n");
    }
    public void SetName(string Name)
    {
        _Name = Name;
    }
    public int GetTime()
    {
        Console.Write("\nHow long, would you like to do the activity? ");
        int Seconds = Int32.Parse(Console.ReadLine());
        _Time = Seconds;
        return Seconds;
    }
    public void SetActivityTime(int Time)
    {
        _Time = Time;
    }

    public void Starting()
    {
        Console.Clear();
        Spinner spinner = new Spinner();
        spinner.Ready();
    }

    public void Finish()
    {
        Spinner spinner = new Spinner();
        spinner.Done();
        Console.WriteLine($"\nYou have completed the Activity!");
        spinner.ShowSpinner();
    }
     public void CountDown(int time)
    {
        Console.WriteLine();  
        for (int i = time; i > 0; i--)
        {
            Console.Write($"{text}{i}");
            Thread.Sleep(450);
            string nothing = new string('\b', (text.Length + 4));  
            Console.Write(nothing);
        }
        Console.WriteLine($"start!");  
    }


}