using System;

public class Swimming : Activity
{
    private int _laps { get; set; }

    public Swimming(double length, int laps) : base(length)
    {
        _laps = laps;
    }

        public override double GetDistance()
    {
        double distance =  Math.Round(_laps * 50 / 1000 * 0.62, 1);
        return distance;
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
        Console.WriteLine($" Swimming ({GetLength()} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()}, Pace: {GetPace()} min per mile");
    }
}