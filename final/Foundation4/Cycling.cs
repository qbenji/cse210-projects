using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int durationMin, double speed)     // constructor
        : base(date, durationMin)
    {
        _speed = speed;
    }

    public override double GetDistance()                // get distance
    {
        return (_speed / 60) * GetDurationMin();
    }

    public override double GetSpeed()                   // get speed
    {
        return _speed;
    }

    public override double GetPace()                    // get pace
    {
        return 60 / _speed;
    }

}