using System;

public class Biking : Activity
{
    private double _speed { get; set; }

    public Biking(double length, double speed) : base(length)
    {
        _speed = speed;
    }

        public override double GetDistance()
    {   
        double distance = Math.Round(GetLength() * GetSpeed() / 60, 1);
        return distance;
    }

    public override double GetSpeed()
    {
        return Math.Round(_speed, 1);
    }

    public override double GetPace()
    {
        double pace = Math.Round(60 / GetSpeed(), 1);
        return pace;
    }

    public override void Display()
    {
        Console.WriteLine($" Stationary Bike ({GetLength()} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()}, Pace: {GetPace()} min per mile");
    }
}