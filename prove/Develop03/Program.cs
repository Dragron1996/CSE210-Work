using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        var John = new List<Scripture>
        {
            new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture("1 Corinthians 10:31", "Whether therefore ye eat, or drink, or whatsoever ye do, do all to the glory of God."),
            new Scripture("1 John 1:9", "If we confess our sins, he is faithful and just to forgive us our sins, and to cleanse us from all unrighteousness."),

        };

        Random vars = new Random();
        var varsScripture = John[vars.Next(John.Count)];
        Console.Clear();
        varsScripture.DisplayScripture();

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
                varsScripture.HideWord();
                varsScripture.DisplayScripture();

                if(varsScripture.AllWordsHidden())
                {
                    Console.WriteLine("Finished!");
                    break;
                }

            }


        }
    }
}