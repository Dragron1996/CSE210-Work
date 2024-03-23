using System;
using System.Diagnostics;

public class ReflectingActivity : Activity
{
    
    private List<string> _List = new List<string>
    {
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless.",
    "Think of a time when you failed at something."
    };
    private List<string> _otherList = new List<string>
    {
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?",
    "What was your motivation?"
    };
    private List<string> _anotherList = new List<string>();

    private string _prompt;
    private string _question;
    private string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";


    
    public ReflectingActivity(string activityName, int activityTime) : base(activityName, activityTime)
    {

    }
    public void GetDescription()
    {
        Console.WriteLine(_description);
    }
    private string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_List.Count);
        _prompt = _List[index];
        return _List[index];
    }
    private string GetQuestion()
    {
        var random = new Random();
        int index = random.Next(_anotherList.Count);
        _question = _anotherList[index];
        return _question;
    }
    public void ShowPrompt(int seconds)
    {
        Console.WriteLine();  
        GetPrompt();
        Console.WriteLine("\nThink about");
        Console.WriteLine($"\n--- {_prompt} ---");
        Console.WriteLine($"\nWhen you are done press enter.");

        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Enter)
        {
            ShowQuestion(seconds);
        }
    }
    public void ShowQuestion(int seconds)
    {
        _anotherList.AddRange(_otherList); 
        Spinner spinner = new Spinner();
        Console.WriteLine($"\nNow ponder.");
        CountDown(6);
        Console.Clear();
        Stopwatch timer = new Stopwatch();
        timer.Start();
        while (timer.Elapsed.TotalSeconds < seconds)
        {
            if (_anotherList.Count != 0)
            {
                var question = GetQuestion();
                Console.Write($"\n>> {_question}  ");
                _anotherList.Remove(_question);  
            }
            spinner.ShowSpinner();
        }
        timer.Stop();
    }

}