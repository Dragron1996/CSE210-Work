using System;
using System.Threading;



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        int x;
        x = 5;
        Console.WriteLine(x);
        int y = 6;
        Console.WriteLine(y);
        Console.Write("No new Line after this");
        Console.WriteLine("There will be a line for us");

        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine(name);
    }
}
    
