using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        
        Console.Clear();
        
        Choices choice = new Choices();
        int seconds;

        int action = 0;
        while (action != 4)
        {
           
            action = choice.Choice();
            switch (action)
            {
                case 1:
                   
                    Console.Clear();
                    Breathing breathing = new Breathing("Breathing", 0);
                    breathing.GetName();
                    breathing.GetDescription();
                    seconds = breathing.GetTime();
                    breathing.Starting();
                    breathing.theactivity(seconds);
                    breathing.Finish();
                    break;
                case 2:
                    
                    Console.Clear();
                    ReflectingActivity reflecting = new ReflectingActivity("Reflecting", 0);
                    reflecting.GetName();
                    reflecting.GetDescription();
                    seconds = reflecting.GetTime();
                    reflecting.Starting();
                    reflecting.ShowPrompt(seconds);
                    reflecting.Finish();
                    break;
                case 3:
                   
                    Console.Clear();
                    ListingActivity listing = new ListingActivity("Listing", 0);
                    listing.GetName();
                    listing.GetDescription();
                    seconds = listing.GetTime();
                    listing.Starting();
                    listing.Return(seconds);
                    listing.Finish();
                    break;
                case 4:
                    
                    Console.WriteLine("\nGood Bye\n");
                    break;
                default:
                    Console.WriteLine($"\nplease enter a number on the menu");
                    break;
            }
        }


    }

}
    
