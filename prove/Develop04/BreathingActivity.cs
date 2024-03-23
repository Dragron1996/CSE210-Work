using System;

public class Breathing : Activity
{
   
    private string _in = "Breathe in";
    private string _out = " out";
    private string _description = "we're going to help you relax. Clear your mind and breath, focus";

  
    public Breathing(string Name, int Time) : base(Name, Time)
    {

    }
    public void GetDescription()
    {
        Console.WriteLine(_description);
    }

    public void theactivity(int seconds)
    {
        Console.WriteLine();  
        int Timer = 0;
        while (Timer < seconds)
        {
            Console.WriteLine();  
            for (int i = 4; i > 0; i--)
            {
                Console.Write($"{_in}{i}");
                Thread.Sleep(450);
                string nothing = new string('\b', (_in.Length + 2));  
                Console.Write(nothing);
                Timer += 1;
            }
            Console.WriteLine($"{_in}  "); 
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"{_out}{i}");
                Thread.Sleep(450);
                string nothing = new string('\b', (_out.Length + 2));  
                Console.Write(nothing);
                Timer += 1;
            }
            Console.WriteLine($"{_out}  ");  
        }
    }
}