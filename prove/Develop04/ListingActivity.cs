using System;
using System.Diagnostics;

public class ListingActivity : Activity
{
    
    private List<string> _List = new List<string>
    {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
    };
    private List<string> _otherlist = new List<string>();
    private string _message = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";


   
    public ListingActivity(string Name, int Time) : base(Name, Time)
    {

    }
    public void GetDescription()
    {
        Console.WriteLine(_message);
    }
    private string Prompt()
    {
        var random = new Random();
        int index = random.Next(_List.Count);
        return _List[index];
    }
    public void Return(int seconds)
    {
        Console.WriteLine();  
        string question = Prompt();
        Console.WriteLine("\nwrite as many as you can:");
        Console.WriteLine($"\n--- {question} ---");
        CountDown(5);
        Timer(seconds);
    }
    public void Timer(int seconds)
    {
        Stopwatch timer = new Stopwatch();
        timer.Start();
        while (timer.Elapsed.TotalSeconds < seconds)
        {
            Console.Write("> ");
            _otherlist.Add(Console.ReadLine());
        }
        timer.Stop();
        int number = _otherlist.Count;
        Console.WriteLine($"\nYou listed {number} items!");
    }





}