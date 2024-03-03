using System;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What did you get as a grade percentage ");
        string valueFromUser = Console.ReadLine();
        string grade_letter = " ";
        

        int grade = int.Parse(valueFromUser);
        if (grade >= 90) 
        {
           grade_letter = ("A");
        }
        else if (grade < 90 && grade >= 80)
        {
            grade_letter = ("B");
        }
        else if (grade <80 && grade >=70)
        {
            grade_letter = ("C");
        }
        else if (grade <70 && grade >=60)
        {
            grade_letter = ("D");
        }
        else 
        {
            grade_letter= ("F");
        }
      

        Console.WriteLine($"You got a {grade_letter}");

        if (grade >= 70)
        {
            Console.WriteLine("You pass the class");
        }
        else if (grade < 70)
        {
            Console.WriteLine("Sorry, but you failed the class");
        }
    }

    
}