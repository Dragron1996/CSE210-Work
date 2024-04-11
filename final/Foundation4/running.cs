using System;

public class Running : Activity
{
    private double _distance { get; set; }

    public Running(double length, double distance) : base(length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return Math.Round(_distance, 1);
    }

    public override double GetSpeed()
    {
        double speed = Math.Round(GetDistance() / GetLength() * 60, 1);
        return speed;
    }

    public override double GetPace()
    {
        double pace = Math.Round(GetLength() / GetDistance(), 1);
        return pace;
    }

    public override void Display()
    {
        Console.WriteLine($" Running ({GetLength()} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()}, Pace: {GetPace()} min per mile");
    }
}