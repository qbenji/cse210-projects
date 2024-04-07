using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int durationMin, int laps)     // constructor
        : base(date, durationMin)
    {
        _laps = laps;
    }

    public override double GetDistance()                // get distance
    {
        return _laps * 50 / 1000;
    }

    public override double GetSpeed()                   // get speed
    {
        return GetDistance() / GetDurationMin() * 60;
    }

    public override double GetPace()                    // get pace
    {
        return GetDurationMin() / GetDistance();
    }

}