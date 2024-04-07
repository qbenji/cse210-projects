using System;

public class Running : Activity
{
    private double _distance;
    public Running(DateTime date, int durationMin, double distance)     // constructor
        : base(date, durationMin)
    {
        _distance = distance;
    }

    public override double GetDistance()                                // get distance
    {
        return _distance;
    }

    public override double GetSpeed()                                   // get speed
    {
        return _distance / GetDurationMin();
    }

    public override double GetPace()                                    // get pace
    {
        return GetDurationMin() / _distance;
    }

} 