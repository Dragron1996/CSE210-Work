using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        List<Activity> activities = new List<Activity>();

        Running running = new Running(35, 4);
        activities.Add(running);
        Biking StationaryBike = new Biking(30, 12);
        activities.Add(StationaryBike);
        Swimming swimming = new Swimming(55, 45);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            activity.Display();
    }
}
}