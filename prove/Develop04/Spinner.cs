using System;
using System.Diagnostics;

public class Spinner
{
     
    int counter;


   
    public void Stopwatch()
    {
        Stopwatch timer = new Stopwatch();
        timer.Start();
        while (timer.Elapsed.TotalSeconds < 8)
        {
            Console.Write("+");

            Thread.Sleep(250);

            Console.Write("\b \b"); 
            Console.Write("-"); 
        }
        timer.Stop();

    }

    public void Turn()
    {
        counter++;
        switch (counter % 4)
        {
            case 0: Console.Write("=>"); break;
            case 1: Console.Write("==>"); break;
            case 2: Console.Write("===>"); break;
            case 3: Console.Write("====>"); break;
        }
        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
    }

    public void ShowPercentage()
    {
        for (int i = 0; i <= 100; i++)
        {
            Console.Write($"\rGet Ready {i}%   ");
            Thread.Sleep(25);
        }
        Console.Write("\rGet Ready");
    }

    public void ShowSpinner()
    {
        var counter = 0;
        for (int i = 0; i < 50; i++)
        {
            switch (counter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            counter++;
            Thread.Sleep(50);
        }
    }

    public void Ready()
    {
        var counter = 0;
        for (int i = 0; i < 50; i++)
        {
            switch (counter % 4)
            {
                case 0: Console.Write("Starting /"); break;
                case 1: Console.Write("Starting -"); break;
                case 2: Console.Write("Starting \\"); break;
                case 3: Console.Write("Starting |"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 14, Console.CursorTop);
            counter++;
            Thread.Sleep(40);
        }
    }
    public void Done()
    {
        Console.WriteLine();
        var counter = 0;
        for (int i = 0; i < 50; i++)
        {
            switch (counter % 4)
            {
                case 0: Console.Write("Finish /"); break;
                case 1: Console.Write("Finsih -"); break;
                case 2: Console.Write("Finish \\"); break;
                case 3: Console.Write("FInish |"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 13, Console.CursorTop);
            counter++;
            Thread.Sleep(40);
        }
    }




}