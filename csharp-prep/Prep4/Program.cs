using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        Console.WriteLine("Add a number to the list");
        int new_number = int.Parse(Console.ReadLine());

        

        while (new_number != 0)
        {
            numbers.Add(new_number);
            
            new_number = int.Parse(Console.ReadLine());
        }

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}