using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        Address address = new Address("Merlin's Tower", "Camelot", "Camelot", "Brittania");

        Lecture lecture = new Lecture("Meet Merlin", "Meet the Wizard that guided and taught our King Learn from wisdom", "July 14, 0023", "Sun Rise", address, "Merlin", 45);
        Console.WriteLine();

        Console.WriteLine("Event 1");
        Console.WriteLine();
        Console.WriteLine(lecture.GetStandard());

        Console.WriteLine();
        Console.WriteLine(lecture.GetLongLecture());

        Console.WriteLine();
        Console.WriteLine(lecture.GetLecture());

        Address addressR = new Address("Arthur's Castle", "Camelot", "Camelot", "Brittania");

        Reception reception = new Reception("Meet the King", "Meet the King! Weilder of Excalibur and witness the one that protects us all", "July 14, 0023", "Sun set", addressR, "Reservation to meet the King at the town hall");
        Console.WriteLine();

        Console.WriteLine("Event 2");
        Console.WriteLine();
        Console.WriteLine(reception.GetStandard());

        Console.WriteLine();
        Console.WriteLine(reception.GetLongReception());

        Console.WriteLine();
        Console.WriteLine(reception.GetReception());

        Address addressOG = new Address("Jousting Hall", "Camelot", "Camelot", "Brittania");

        OutdoorGathering outdoorGathering = new OutdoorGathering("The Joust", "Watch the knights joust each other, we all know Lancelot will win, but see who will come second", "July 14, 0023", "High Noon", addressOG, "cloudy");
        Console.WriteLine();

        Console.WriteLine("Event 3");

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetStandard());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetLongOutdoorGathering());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetOutdoorGathering());
    }
}
    
