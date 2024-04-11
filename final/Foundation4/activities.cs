using System;

public abstract class Activity
{
    private double _length { get; set; }

    public Activity(double length)
    {
        _length = length;
    }



    public double GetLength()
    {
        return _length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract void Display();
}