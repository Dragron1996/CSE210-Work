using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Scripture John = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        Console.Clear();
        John.DisplayScripture();

        while(true)
        {
            Console.WriteLine("Enter to memorize more or type quit");
            string Player = Console.ReadLine();

            if (Player.ToUpper() == "QUIT")
            {
                break;
            }
            else
            {
                Console.Clear();
                John.HideWord();
                John.DisplayScripture();

                if(John.AllWordsHidden())
                {
                    Console.WriteLine("Finished!");
                    break;
                }

            }


        }
    }
}