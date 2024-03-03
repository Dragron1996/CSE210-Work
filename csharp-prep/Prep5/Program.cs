using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayMessage();
        string name = PromptUserName();
        int favorite_number = PromptUserNumber();
        int square_number = SquareNumber(favorite_number);
        DisplayResult(square_number, name);

        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        
        static string PromptUserName()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            return name;

        }

        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number?");
            int favorite_number = int.Parse(Console.ReadLine());
            return favorite_number;
        }

        static int SquareNumber(int favorite_number)
        {
            int square_number = favorite_number * favorite_number;
            return square_number;

        }

        static void DisplayResult(int square_number, string name)
        {
            Console.WriteLine($"{name} your favorite number squared is {square_number}");
        }
    }
}