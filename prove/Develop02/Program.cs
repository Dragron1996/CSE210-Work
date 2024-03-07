using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        string choice = "";
        string write = "";
        string prompt = "";
        
        List<string> entries = new List<string>();
        //List<string> SaveFile = new List<string>();
        Entries savefile = new Entries();
        Entries Option2 = new Entries();
        SaveFile save = new SaveFile();
        SaveFile blank = new SaveFile();
        
        while (choice != "5")
        {
        Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("6. Don't know what to do?");

        Console.Write("What do you want to do?");
        choice = Console.ReadLine();

        if (choice == "1")       
        {
           Console.WriteLine("You've chosen to Write");
           Random randomGenerator = new Random();
            int randoNumber = randomGenerator.Next(1, 10);
            Console.WriteLine(randoNumber);
            if (randoNumber == 1)
            {
                Console.Write("Who was the most interesting person I interacted with today?");
                write = Console.ReadLine();
                prompt = ("Who was the most interesting person I interacted with today?");
                entries.Add($"5/21/2023 - {prompt}\n{write}");
            }
            else if (randoNumber == 2)
            {
                Console.Write("What was the best part of my day?");
                write = Console.ReadLine();
                prompt = ("What was the best part of my day?");
                entries.Add($"5/21/2023 - {prompt}\n{write}");
               
            }
            else if (randoNumber == 3)
            {
                Console.Write("How did I see the hand of the Lord in my life today?");
                write = Console.ReadLine();
                prompt = ("How did I see the hand of the Lord in my life today?");
                entries.Add($"5/21/2023 - {prompt}\n{write}");
            }
            else if (randoNumber == 4)
            {
                Console.Write("What was the strongest emotion I felt today?");
                write = Console.ReadLine();
                prompt = ("What was the strongest emotion I felt today?");
                entries.Add($"5/21/2023 - {prompt}\n{write}");
            }
            else if (randoNumber == 5)
            {
                Console.Write("If I had one thing I could do over today, what would it be?");
                write = Console.ReadLine();
                prompt = ("If I had one thing I could do over today, what would it be?");
                entries.Add($"5/21/2023 - {prompt}\n{write}");
            }
            else if (randoNumber == 6)
            {
                Console.Write("What was your favorite conversation today?");
                write = Console.ReadLine();
                prompt = ("What was your favorite conversation today?");
                entries.Add($"5/21/2023 - {prompt}\n{write}");
            }
            else if (randoNumber == 7)
            {
                Console.Write("What are you grateful for today?");
                write = Console.ReadLine();
                prompt = ("What are you grateful for today?");
                entries.Add($"5/21/2023 - {prompt}\n{write}");
            }
            else if (randoNumber == 8)
            {
                Console.Write("What is one thing you overcame today?");
                write = Console.ReadLine();
                prompt = ("What is one thing you overcame today?");
                entries.Add($"5/21/2023 - {prompt}\n{write}");
            }
            else if (randoNumber == 9)
            {
                Console.Write("What is something new or interesting you have learned today");
                write = Console.ReadLine();
                prompt = ("What is something new or interesting you have learned today");
                entries.Add($"5/21/2023 - {prompt}\n{write}");
            }
            else if (randoNumber == 10)
            {
                Console.Write("What act of kindness have you seen or done today?");
                write = Console.ReadLine();
                prompt = ("What act of kindness have you seen or done today?");
                entries.Add($"5/21/2023 - {prompt}\n{write}");
            }

            Journal journal1 = new Journal();
            journal1._prompt = prompt;
            journal1._write = write;
            journal1.Display();
            
            Option2._entries.Add(journal1);
        }
        else if (choice == "2")
        {
            Console.WriteLine("You've chosen the display");
            
            Option2.Display();
            save.Display();
            
        }
        else if (choice == "3")
        {
            Console.WriteLine("You've chosen to load");
            Console.Write("What is the name of the save file?");
            string LoadFile = Console.ReadLine();
            if (save._name == LoadFile)
            {
                Option2._entries.Clear();
                Option2.Load(save);
                Option2.Display();
            }
            
            
        }
        else if (choice == "4")
        {
            
            Console.WriteLine("You've chosen to save");
            Console.Write("Give a name to your savefile");
            string SaveFileName = Console.ReadLine();
            save._name = SaveFileName;
            
            save.Save(Option2);
            //save._entries = Option2._entries;
            //blank._entries = save._entries;
            //save._entries = blank._entries;
            //Option2.Save();
            
            //save._entries.Add(Option2);
            //save.Display();
                
        }
        else if (choice == "6")
        {
             Random randomGenerator1 = new Random();
            int randoNumber1 = randomGenerator1.Next(1, 5);
            Console.WriteLine(randoNumber1);
            if (randoNumber1 == 1)
            {
                Console.WriteLine("Today let's focus on gaining muscles. Go to the Gym.");
            }
            if (randoNumber1 == 2)
            {
                Console.WriteLine("Today let's focus on gaining Speed. Run a mile as fast as you can.");
            }
            if (randoNumber1 == 3)
            {
                Console.WriteLine("Today let's focus on gaining cardio. Run as long as you can then you can stop.");
            }
            if (randoNumber1 == 4)
            {
                Console.WriteLine("Today let's work on your happiness. Write down three things you are grateful for.");
            }
            if (randoNumber1 == 5)
            {
                Console.WriteLine("Today let's focus on your career. Go to work and give it your all");
            }
        }
        else
        {
            Console.WriteLine("You're quitting");
        }
        }
    }
}