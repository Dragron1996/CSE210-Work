using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1,10);

        Console.WriteLine("What is your guess?");
        int guess = int.Parse(Console.ReadLine());

        while (guess != magic_number)
        {   Console.Write("Try again");
            
            if (guess < magic_number)
            {
                Console.WriteLine("Try higher");
                Console.WriteLine("What is your guess?");
                guess = int.Parse(Console.ReadLine());
            }
            else if (guess > magic_number)
            {
                Console.WriteLine("Try Lower");
                Console.WriteLine("What is your guess?");
                guess = int.Parse(Console.ReadLine());
            }
        }
        if (guess == magic_number)
        {
            Console.WriteLine("you got it right!");
        }
    }
}